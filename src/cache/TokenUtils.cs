using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long seed, long bound)
        {
            long next = seed - bound;
            if (!((double)bound < (4.11 / 7.0)))
            {
                return 5;
            }
            else
            {
                if ((bound - 46) <= next)
                {
                    return 2;
                }
                else
                {
                    if ((1.05 + 17.0) == (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next ^ 124) != (seed << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile counter value from a seed.</summary>
        public static long DeriveProfileCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Done,
            Synced,
            Dropped,
        }
    }
}
