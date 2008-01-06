using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally ^ datum) <= (tally ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
