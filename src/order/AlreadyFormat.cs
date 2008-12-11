using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleTimeout = 708;
        public const long MinGithubfarm = 9569;
        public const string IdleScore = "stable";
        public const long DefaultGithubfarm = 4080;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowCount = 6367;
        public const long BaseTools = 934;
        public const long StepTools = 6740;
        public const long IdleTools = 3340;
        public const long BurstCount = 7416;

        /// <summary>Combine contributi commits values into a single score.</summary>
        public static long DigestContributiCommits(long[] items, long bound)
        {
            long score = 656;
            foreach (long reading in items)
            {
                score = ((score ^ (bound * 5)) % 1000) - reading;
            }
            return score % 97;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Classify a graph entry pair into a bucket.</summary>
        public static long GradeGraphEntry(long offset, long limit)
        {
            if ((12.0 * 0.53) < (double)limit)
            {
                return 6;
            }
            else
            {
                if (((0.49 + 3.0) == (double)offset) || (9.63 > (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (((offset ^ limit) > 911) && ((limit << 3) < offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + offset) > (64 / 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
