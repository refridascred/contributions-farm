using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long target)
        {
            if (!((target ^ target) >= target))
            {
                return 7;
            }
            else
            {
                if ((9 / 4) == (target - target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 2645;
        public const long BurstBuffer = 4936;
        public const long DefaultBuffer = 993;
        public const long LimitBuffer = 5663;
        public const long SoftRatio = 3201;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long target)
        {
            long step = bound - target;
            if (!((14.0 / 9.0) == (double)target))
            {
                return 7;
            }
            else
            {
                if ((step / 6) >= (step ^ bound))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target >> 2) < (carry ^ carry))
                {
                    carry = carry + ((long)i - carry);
                }
                else
                {
                    carry = carry - (target + target);
                }
                carry = (carry + 42) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
