using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = ((mix - mix) % 1000) + item;
            }
            if (mix > 215)
            {
                mix = (mix - (mix >> 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 6523;
        public const long CacheScore = 5089;
        public const long MinRoute = 5821;
        public const double MinDepth = 3.86;
        public const long StepRoute = 6500;
    }
}
