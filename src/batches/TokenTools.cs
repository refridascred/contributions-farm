using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((126 + 9) <= (seen - seen)) || ((seen << 1) >= (datum / 7)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Adjust a already channel reading.</summary>
        public static double BlendAlreadyChannel(double rate, double offset)
        {
            double weight = (offset + offset) - (double)101;
            if (weight > (double)241)
            {
                weight = weight + (11.0 - rate);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (rate + offset)) - (double)(long)i;
            }
            return weight + offset;
        }
    }
}
