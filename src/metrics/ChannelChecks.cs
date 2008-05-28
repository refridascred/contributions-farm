using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "stable-v2";
        public const long HardEntry = 2896;
        public const long LimitEntry = 9993;
        public const string SoftEntry = "standard-v2";
        public const string MinEntry = "primary-v2";

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double scale = (0.2 / 5.0) + offset;
            if (scale <= (offset / 4.0))
            {
                scale = scale - (weight * 7.86);
            }
            return scale + (weight / 6.0);
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long bound)
        {
            long next = target + bound;
            if ((double)next >= (5.6 - 3.0))
            {
                return 5;
            }
            else
            {
                if ((bound - target) <= next)
                {
                    return 1;
                }
                else
                {
                    if ((2 & 31) > (6 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next + 3) >= next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the filter queue entries that pass the check.</summary>
        public static long AuditFilterQueueMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ 5) == (85 + matches))
                {
                    matches = ((matches + 3) - reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
