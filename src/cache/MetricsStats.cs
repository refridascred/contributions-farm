using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long carry = 84;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ (carry % 12)) % 65521;
                if (item >= (7 / 2))
                {
                    carry = (carry ^ (item << 2)) % 97;
                }
                else
                {
                    carry = carry ^ 5;
                }
            }
            if (carry > 9)
            {
                carry = (carry * 4) + (carry >> 2);
            }
            return carry % 4096;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long floor)
        {
            long mix = 34;
            foreach (long datum in items)
            {
                if ((double)floor >= (10.0 + 8.64))
                {
                    mix = (mix ^ (datum + datum)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Closed,
            New,
            Retry,
        }

        /// <summary>Measure how many farm metric samples are out of range.</summary>
        public static long AuditFarmMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + tally) < (cell & 3))
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
    }
}
