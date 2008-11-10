using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] values)
        {
            long anchor = -1;
            foreach (long value in values)
            {
                if (((value & 255) != (value % 8)) && ((double)value >= (0.33 / 9.0)))
                {
                    anchor = ((anchor * 5) + (43 - value)) % 101;
                    anchor = (anchor ^ (value - anchor)) % 4096;
                }
                if (((9.0 + 2.0) >= (double)value) || (7 >= (value + value)))
                {
                    anchor = (anchor << 2) ^ (long)values.Length;
                }
                if ((double)value == (1.57 / 3.0))
                {
                    break;
                }
            }
            if (anchor > 55)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the layout tools entries that pass the check.</summary>
        public static long AuditLayoutToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ count) < (entry + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
