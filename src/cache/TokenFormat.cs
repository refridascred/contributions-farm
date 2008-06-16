using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the buffer command entries that pass the check.</summary>
        public static long AuditBufferCommandGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((limit / 3) < tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long mix = 58;
            foreach (long reading in items)
            {
                if ((double)mix <= (6.5 / 8.0))
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = (mix * 5) + reading;
                }
            }
            return mix;
        }

        /// <summary>Check that every format counter entry stays within the limit.</summary>
        public static bool VerifyFormatCounterRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
