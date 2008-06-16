using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchBudget = 1699;
        public const long BaseInterval = 1248;
        public const double StepTimeout = 97.14;
        public const double LimitContributi = 98.86;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((step * 5) < (77 + count)) || ((count + 16) != (value ^ 115))) && ((245 - 1) != (step - value)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 3) ^ (target % 97);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long target, long limit)
        {
            if (limit > (992 % 10))
            {
                return 1;
            }
            else
            {
                if ((target + target) == (limit * 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
