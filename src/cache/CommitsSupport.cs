using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long target)
        {
            long diff = offset - target;
            if ((offset + 72) >= (target - diff))
            {
                return 2;
            }
            else
            {
                if ((201 - offset) >= (diff << 1))
                {
                    return 5;
                }
                else
                {
                    if ((diff >> 3) < 6)
                    {
                        return 1;
                    }
                    else
                    {
                        if (target < diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 96.87;
        public const string DefaultContext = "stable-v2";
        public const long WindowContext = 903;
        public const double MaxContext = 43.33;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long carry = -378;
            foreach (long value in readings)
            {
                carry = (carry * 5) + (carry - value);
                carry = ((carry << 3) ^ (value >> 1)) % 65521;
                if ((carry % 3) > (limit % 3))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
