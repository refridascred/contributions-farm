using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long carry = 54;
            foreach (long item in data)
            {
                carry = ((carry - item) % 4096) + floor;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                long cur = (sample / 5) * 4;
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry << 2) ^ (cur - cur)) + (long)i;
                }
                if (((double)(long)items.Length <= (9.83 + 17.0)) && ((sample >> 2) > (sample << 2)))
                {
                    carry = carry - (carry + 75);
                }
                else
                {
                    carry = carry ^ (sample - carry);
                }
            }
            if (carry < 8)
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry % 97;
        }
    }
}
