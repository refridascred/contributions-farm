using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token report samples are out of range.</summary>
        public static long CountTokenReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((-3) >> 1) == (matches / 5)) && (((double)reading == (12.0 + 19.0)) || ((reading % 16) < reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples, long step)
        {
            long carry = 57;
            foreach (long item in samples)
            {
                if (((511 + 3) <= (step / 6)) && ((1 & 3) != (step << 1)))
                {
                    carry = (carry + (carry - item)) % 101;
                }
                else
                {
                    carry = (carry * 5) + carry;
                }
                if ((item / 8) > (step >> 5))
                {
                    break;
                }
            }
            if (carry < 67)
            {
                carry = (carry - step) % 101;
            }
            return carry;
        }

        /// <summary>Roll a cluster layout counter forward.</summary>
        public static long DeriveClusterLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + step) % 97) + (long)i2;
                    anchor = (anchor - step) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
