using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxWidth = 4333;
        public const string BurstSchema = "cached-edge";
        public const long IdleCount = 5720;

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "open-v2";
        public const long HardLayout = 957;
        public const long StepSpan = 4275;

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series, long step)
        {
            long score = 50;
            foreach (long cell in series)
            {
                score = (((score ^ score) % 1000) + cell) + step;
            }
            if (score < 335)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
