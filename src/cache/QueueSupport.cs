using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item != (17.0 / 6.0))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(carry < 848))
                {
                    carry = carry - floor;
                }
                carry = ((carry << 2) ^ ((long)i / 2)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Retry,
            Idle,
        }
    }
}
