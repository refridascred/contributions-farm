using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank already stream input into a small class.</summary>
        public static long ClassifyAlreadyStream(long step, long offset)
        {
            long lane = step ^ offset;
            if ((lane < (step ^ step)) && ((452 - offset) <= (offset - offset)))
            {
                return 4;
            }
            else
            {
                if (!((offset * 5) <= (offset - lane)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Idle,
            Dropped,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long carry = 5;
            foreach (long value in readings)
            {
                if (((48 << 2) == (carry + (long)readings.Length)) || (seed < (496 * 5)))
                {
                    carry = ((carry * 2) + (640 % 5)) ^ value;
                }
            }
            return carry;
        }
    }
}
