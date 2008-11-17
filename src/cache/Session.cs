using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((entry % 64) > entry) || !((entry - 492) > 78))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double rate = offset * 4.0;
            if (rate <= offset)
            {
                rate = rate - offset;
            }
            return rate + ratio;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long state = 27;
            foreach (long value in values)
            {
                if (((value ^ origin) >= (state + state)) && ((double)origin == (double)value))
                {
                    state = state ^ value;
                }
                else
                {
                    state = (state << 3) ^ (6 >> 4);
                }
            }
            if (state > 550)
            {
                state = (state << 3) ^ (state ^ state);
            }
            return state % 65521;
        }
    }
}
