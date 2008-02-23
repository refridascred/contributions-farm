using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Stale,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] series, long seed)
        {
            long acc = 933;
            foreach (long item in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc - seed) ^ (long)i;
                }
                if ((66 << 3) < seed)
                {
                    acc = (acc ^ (item & 63)) % 4096;
                }
            }
            return acc % 1000;
        }
    }
}
