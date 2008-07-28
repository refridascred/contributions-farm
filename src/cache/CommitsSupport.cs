using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 + 0.9;
        }

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
