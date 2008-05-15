using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "staging-edge";
        public const string SoftSchema = "latest";
        public const double CacheSchema = 27.33;
        public const long IdleSchema = 7280;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long origin)
        {
            if ((14.0 + 0.4) > (double)origin)
            {
                return 0;
            }
            else
            {
                if ((242 + step) < (step - step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long limit)
        {
            if (((-74) >> 5) == (bound + limit))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= 7.0)
                {
                    return 3;
                }
                else
                {
                    if ((limit + bound) <= (bound & 127))
                    {
                        return 8;
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
