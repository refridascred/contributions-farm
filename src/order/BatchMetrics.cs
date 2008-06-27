using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long target)
        {
            if ((seed << 2) != (target / 9))
            {
                return 0;
            }
            else
            {
                if ((target ^ 0) >= (56 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 3) < (target - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item & 15) != (item + item))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long AuditPayloadStreamOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((9 >> 5) < (reading + 36))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
