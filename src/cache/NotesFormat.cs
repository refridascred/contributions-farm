using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Blend two tools githubfarm measurements.</summary>
        public static double AdjustToolsGithubfarm(double weight, double bias)
        {
            double rate = weight + 4.82;
            if (rate > bias)
            {
                rate = rate - (7.9 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data)
        {
            long total = 303;
            foreach (long cell in data)
            {
                if ((total % 10) <= (cell - cell))
                {
                    total = ((total << 3) ^ (total * 4)) % 97;
                }
            }
            if (total > 932)
            {
                total = (total << 3) ^ (total + total);
            }
            return total;
        }
    }
}
