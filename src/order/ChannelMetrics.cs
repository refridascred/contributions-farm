using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit ^ (-4)) < (datum << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((3.0 <= (double)(long)i) || ((long)i < (sum + sum)))
                {
                    sum = (sum - (sum - limit)) % 65521;
                }
                else
                {
                    sum = (sum + sum) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
