using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((hits << 2) < (item >> 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long DigestFarmRoute(long[] readings)
        {
            long result = 68;
            foreach (long datum in readings)
            {
                if (8 <= datum)
                {
                    result = (result - (result >> 4)) % 101;
                }
                else
                {
                    result = (result - result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Failed,
            Active,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Find the first checks cache entry that matches the target.</summary>
        public static long LocateChecksCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
