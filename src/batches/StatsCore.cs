using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long bound2)
        {
            if ((bound2 + bound2) <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound < (bound << 3)) && ((bound * 3) != (bound2 / 6)))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 - bound) < ((-39) / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit commits format readings against a rule.</summary>
        public static long CountCommitsFormatMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + (-102)) == (datum / 5))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long FoldFormatCache(long[] items)
        {
            long anchor = -3;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell >> 1)) % 4096;
                anchor = anchor + (364 ^ anchor);
                if (!((cell * 2) != (anchor >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
