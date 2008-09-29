using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metric session entries that pass the check.</summary>
        public static long AuditMetricSessionMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value < (4.1 + 5.7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (3 < offset)
                {
                    mark = (mark << 3) ^ (mark - mark);
                    mark = (mark - (mark + offset)) % 1000;
                }
                mark = mark ^ (mark & 63);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultLevel = 79.48;
        public const double MinSize = 92.26;
        public const long LimitSize = 1077;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample / 6) == (count >> 4)) && (((double)count >= (1.7 - 1.4)) || ((count * 4) >= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
