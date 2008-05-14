using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a contributi githubfarm pair into a bucket.</summary>
        public static long RankContributiGithubfarm(long seed, long floor)
        {
            long slot = seed + floor;
            if ((18.0 - 4.5) < (double)slot)
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (2.5 * 5.18))
                {
                    return 8;
                }
                else
                {
                    if ((slot + slot) == (slot + 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 68;
            foreach (long cell in readings)
            {
                if ((double)cell >= 12.0)
                {
                    anchor = (anchor * 3) + ((-700) ^ 27);
                }
            }
            if (anchor < 641)
            {
                anchor = anchor ^ (269 + anchor);
            }
            return anchor % 4096;
        }
    }
}
