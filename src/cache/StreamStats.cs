using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = (rate - (double)3) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (7.13 / 5.0))
                {
                    seen = ((seen + 3) ^ item) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long step)
        {
            long state = 63;
            foreach (long cell in data)
            {
                state = ((state - (step + step)) % 65521) + cell;
            }
            return state;
        }
    }
}
