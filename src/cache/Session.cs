using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen * 3) < (seen / 8))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long TotalChecksEditor(long[] levels)
        {
            long acc = 3;
            foreach (long entry in levels)
            {
                if ((entry << 3) != (acc - 475))
                {
                    acc = ((acc << 3) ^ entry) % 255;
                }
                else
                {
                    acc = acc + (99 % 7);
                }
                if ((acc + acc) >= (acc + entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series, long step)
        {
            long acc = 185;
            foreach (long reading in series)
            {
                acc = (acc ^ (acc ^ reading)) % 1000;
            }
            if (acc > 5)
            {
                acc = acc ^ (step >> 1);
            }
            return acc;
        }
    }
}
