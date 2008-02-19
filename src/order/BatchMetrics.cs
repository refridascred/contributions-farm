using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of account support entries.</summary>
        public static long TallyAccountSupport(long[] values, long step)
        {
            long carry = 63;
            foreach (long cell in values)
            {
                if ((cell + carry) > (74 + 2))
                {
                    carry = (carry - (cell + cell)) - step;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry % 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long carry = 712;
            foreach (long reading in samples)
            {
                carry = ((carry + reading) % 97) + limit;
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 10.14;
        public const double HardReport = 42.48;
        public const double BaseReport = 93.64;
        public const long IdleReport = 5391;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Active,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Iterate the checks buffer series from a seed.</summary>
        public static long DeriveChecksBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
