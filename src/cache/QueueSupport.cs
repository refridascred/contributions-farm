using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double span)
        {
            double weight = span - (double)373;
            if (weight < 4.22)
            {
                weight = weight + (double)808;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight + (scale / 2.0);
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7.9 - 3.9) > (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
