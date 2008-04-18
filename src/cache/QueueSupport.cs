using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of queue githubfarm readings.</summary>
        public static long MatchQueueGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            New,
            Draft,
            Active,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double weight = (2.01 / 6.0) / 3.0;
            if (weight >= (offset / 9.0))
            {
                weight = weight + (double)93;
            }
            else
            {
                weight = weight - (double)44;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (weight - gain);
        }
    }
}
