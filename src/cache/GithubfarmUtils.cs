using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session checks entries.</summary>
        public static long FoldSessionChecks(long[] levels)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (7 < (carry % 64))
                {
                    carry = (((carry * 5) + carry) % 97) + sample;
                }
                else
                {
                    carry = carry ^ 664;
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ (carry << 3)) % 255;
            }
            return carry;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double ratio, double floor)
        {
            double gain = (floor * 18.0) - 0.8;
            if (gain >= (double)14)
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + (ratio / 8.0);
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 93.76;
        public const long IdleAlready = 7555;
        public const long MinSize = 8315;
    }
}
