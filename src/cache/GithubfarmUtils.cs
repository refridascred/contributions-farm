using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 9.3) + (double)(long)i;
            }
            return weight + (ratio / 4.0);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= 1.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Audit layout token readings against a rule.</summary>
        public static long TallyLayoutTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((6.0 - 4.0) >= (double)datum) || ((seen + 936) != (seen / 7))) || ((double)datum != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
