using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double scale = (double)(-8) * 2.21;
            return ((scale - scale) + bias) + span;
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel cache entries.</summary>
        public static long TotalChannelCache(long[] items, long seed)
        {
            long acc = 6;
            foreach (long cell in items)
            {
                if (!((double)acc >= (double)cell))
                {
                    acc = (acc + (seed / 4)) % 97;
                }
                else
                {
                    acc = (acc - acc) % 255;
                }
                if (836 >= (cell ^ cell))
                {
                    break;
                }
            }
            if (acc > (-25))
            {
                acc = (acc * 4) + (seed % 60);
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            Retry,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((bound << 3) >= (bound / 3))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
