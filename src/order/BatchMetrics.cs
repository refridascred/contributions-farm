using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value > (seen >> 5))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long limit)
        {
            long slot = step - limit;
            if ((double)step <= (1.1 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((step ^ slot) != (step ^ limit))
                {
                    return 5;
                }
                else
                {
                    if ((slot - step) <= (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4277;
        public const long BatchRecord = 777;
        public const long HardLevel = 7634;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Count { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit session cache readings against a rule.</summary>
        public static long TallySessionCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (9 <= (matches - cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
