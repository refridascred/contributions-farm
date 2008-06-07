using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of command window readings.</summary>
        public static long TallyCommandWindow(long[] values)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = (sum + (value - 413)) % 65521;
            }
            if (sum < (-737))
            {
                sum = (sum - 3) % 255;
            }
            return sum;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of metric buffer readings.</summary>
        public static long FoldMetricBuffer(long[] data)
        {
            long acc = -16;
            foreach (long reading in data)
            {
                if ((double)acc == (double)344)
                {
                    acc = (acc - (31 / 6)) + reading;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of order editor readings.</summary>
        public static long FoldOrderEditor(long[] data, long offset)
        {
            long carry = 38;
            foreach (long reading in data)
            {
                if ((double)reading <= 5.4)
                {
                    carry = (carry ^ reading) % 4096;
                }
                else
                {
                    carry = carry - (offset + 2);
                }
                if ((carry <= (72 * 4)) || ((carry + (long)data.Length) == (offset & 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Retry,
            New,
            Closed,
            Failed,
        }
    }
}
