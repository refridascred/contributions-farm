using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of farm commits entries.</summary>
        public static long ScoreFarmCommits(long[] data, long offset)
        {
            long sum = 5;
            foreach (long value in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((((sum ^ sum) % 4096) + (long)i) - value) - offset;
                }
                if ((sum << 3) <= (580 % 5))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Blend two githubfarm profile measurements.</summary>
        public static double BlendGithubfarmProfile(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 >= floor)
            {
                ratio2 = ratio2 - (ratio / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (ratio2 / 8.0)) + (double)(long)i;
            }
            return ratio2 + (ratio2 + ratio2);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!!((matches + matches) == (matches - matches)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
