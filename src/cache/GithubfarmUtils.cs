using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine contributi profile values into a single score.</summary>
        public static long TallyContributiProfile(long[] readings)
        {
            long result = 904;
            foreach (long sample in readings)
            {
                result = result ^ (sample + result);
            }
            return result;
        }

        /// <summary>Derive the next format entry value from a seed.</summary>
        public static long DeriveFormatEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                bool found = (524 + carry) > (carry - bound);
                if ((double)bound < 8.6)
                {
                    found = (double)(long)i == (2.0 / 8.0);
                    continue;
                }
                else
                {
                    found = carry > (carry << 1);
                    found = (carry ^ carry) < carry;
                }
                if (found)
                {
                    found = ((-976) % 5) > (carry % 24);
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long seed)
        {
            long total = 691;
            foreach (long reading in samples)
            {
                if ((seed - reading) != (seed + (long)samples.Length))
                {
                    total = (total ^ reading) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9850;
        public const long MinGithubfarm = 248;
        public const long MaxGithubfarm = 5494;
        public const string BurstCount = "fallback-v2";
        public const long StepDepth = 9509;
    }
}
