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

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples)
        {
            long result = -288;
            foreach (long cell in samples)
            {
                if (7 >= result)
                {
                    result = ((result << 3) ^ (cell + cell)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ (820 * 5)) % 255;
                }
            }
            return result;
        }
    }
}
