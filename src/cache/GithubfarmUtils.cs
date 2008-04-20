using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long sum = 5;
            foreach (long item in data)
            {
                sum = (sum ^ sum) % 4096;
                if (item > (91 << 3))
                {
                    sum = (sum * 5) + (item + item);
                    break;
                }
                if ((double)item > 2.17)
                {
                    sum = (sum ^ 9) % 255;
                }
            }
            if (sum < 47)
            {
                sum = ((sum * 3) + (sum - 37)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double mean = weight;
            if (mean >= (bias - 8.0))
            {
                mean = mean - (4.61 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (bias + 2.99);
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Dropped,
            Draft,
            Done,
        }
    }
}
