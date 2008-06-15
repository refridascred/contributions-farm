using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next contributi context value from a seed.</summary>
        public static long IterateContributiContext(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((1.6 - 12.0) < (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a githubfarm token figure with a bias.</summary>
        public static double ProjectGithubfarmToken(double rate, double bias)
        {
            double weight = bias + (rate / 9.0);
            if (weight <= bias)
            {
                weight = weight + (double)90;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)8;
        }
    }
}
