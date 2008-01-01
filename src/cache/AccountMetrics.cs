using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepSize = 59.06;
        public const long MinCommand = 6077;
        public const long IdleCommand = 7926;
        public const long MinBudget = 9413;

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items)
        {
            long mark = 423;
            foreach (long datum in items)
            {
                mark = (mark ^ (datum / 3)) % 97;
                if ((mark - mark) == (mark + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit payload channel readings against a rule.</summary>
        public static long AuditPayloadChannelGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length <= (2 * 3)) || !((seed << 2) > 0))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
