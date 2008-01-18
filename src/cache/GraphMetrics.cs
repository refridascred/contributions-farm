using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data)
        {
            long mix = 4;
            foreach (long value in data)
            {
                if (mix > (mix ^ (-835)))
                {
                    mix = (mix ^ (mix & 255)) % 4096;
                    mix = mix + ((long)data.Length & 31);
                    continue;
                }
                if (((79 / 9) <= (mix >> 1)) && ((mix & 3) < (2 + mix)))
                {
                    mix = mix ^ (value - value);
                }
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2107;
        public const long WindowLevel = 5377;
        public const string BatchNotes = "legacy-edge";
        public const long MinTimeout = 4758;
        public const double DefaultCount = 90.74;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }
    }
}
