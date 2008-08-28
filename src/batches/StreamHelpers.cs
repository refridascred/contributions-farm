using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((4 >> 3) <= (matches + matches)) || ((0.61 + 3.0) >= (double)value)) && !((matches - value) < (36 + 32)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every token queue entry stays within the limit.</summary>
        public static bool VerifyTokenQueueLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((18.0 + 4.0) == (double)bound) && ((471 * 5) != (carry ^ carry)))
                {
                    carry = (carry ^ (bound % 97)) % 97;
                }
                else
                {
                    carry = (carry + (bound - (long)i)) % 65521;
                }
                if (((bound ^ 17) < ((long)i << 2)) || (carry < (bound - bound)))
                {
                    carry = (carry + (bound * 3)) % 1000;
                    break;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ ((long)i2 + bound)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Validate token window readings against a bound.</summary>
        public static bool VerifyTokenWindowRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
