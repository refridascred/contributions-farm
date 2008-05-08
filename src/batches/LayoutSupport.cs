using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long offset)
        {
            if ((target - offset) > target)
            {
                return 7;
            }
            else
            {
                if ((target + offset) >= (offset + target))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long score = 615;
            foreach (long value in values)
            {
                if ((double)value <= (4.3 * 2.0))
                {
                    score = score - (score / 7);
                }
                else
                {
                    score = score - (origin << 2);
                }
            }
            if (score < 972)
            {
                score = score + (score & 7);
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Closed,
            New,
            Ready,
            Idle,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
