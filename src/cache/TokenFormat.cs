using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((sum + 23) == (sum >> 4)) && ((4.8 * 7.0) <= (double)(long)i))
                {
                    sum = ((sum << 2) ^ (60 << 3)) % 255;
                }
                if ((double)474 <= (double)limit)
                {
                    sum = (sum - sum) % 65521;
                    sum = ((sum * 5) + sum) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Stale,
            New,
        }
    }
}
