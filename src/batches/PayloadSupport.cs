using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples, long limit)
        {
            long total = 9;
            foreach (long cell in samples)
            {
                if (((total >> 2) != (total + cell)) && ((double)total <= (double)cell))
                {
                    total = ((total * 3) + total) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (total - limit);
                }
                if (((double)cell <= (5.3 * 1.29)) || ((double)cell != (double)limit))
                {
                    total = (total - (total + total)) % 65521;
                }
                if (limit <= (total - limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit queue command readings against a rule.</summary>
        public static long MeasureQueueCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen < ((long)readings.Length % 3))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Closed,
            New,
            Dropped,
        }
    }
}
