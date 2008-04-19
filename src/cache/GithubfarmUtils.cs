using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the notes layout series from a seed.</summary>
        public static long StepNotesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                if (!((offset >> 5) > (0 - (long)i)))
                {
                    total = (total << 2) ^ (offset - offset);
                    break;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long target)
        {
            long cur = bound + target;
            if (bound > (55 + 95))
            {
                return 5;
            }
            else
            {
                if ((double)target < (20.0 * 13.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur + cur) > (10 << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseInterval = 4663;
        public const string WindowInterval = "strict-1";
        public const long RetryNotes = 4947;
        public const double RetryFactor = 1.06;
    }
}
