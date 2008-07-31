using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (822 > ((long)samples.Length / 9))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double ratio, double floor)
        {
            double weight = (ratio + floor) * 1.98;
            if (weight >= floor)
            {
                weight = weight + (floor / 4.0);
            }
            else
            {
                weight = weight - (floor * 5.1);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (floor * 14.0)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Queued,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (offset2 >= (bound ^ offset2))
            {
                return 2;
            }
            else
            {
                if ((offset + 3) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
