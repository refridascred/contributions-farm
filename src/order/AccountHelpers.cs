using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "latest-1";
        public const double LimitScore = 98.98;
        public const long BurstScore = 7444;
        public const long StepRatio = 3309;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) <= (reading << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long total = -5;
            foreach (long reading in samples)
            {
                if ((total + 100) <= (total + total))
                {
                    total = (((total << 3) ^ (total + 652)) % 1000) ^ reading;
                }
            }
            if (total > 11)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftLevel = "local-1";
        public const long BaseSpan = 7287;
        public const long MaxProfile = 8038;
        public const long CacheProfile = 4787;
        public const long StepWidth = 9364;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            long diff = origin + target;
            if (((1.0 - 7.03) <= (double)target) || ((diff & 15) > (origin ^ origin)))
            {
                return 8;
            }
            else
            {
                if ((origin <= (diff + origin)) && (target >= (diff * 4)))
                {
                    return 2;
                }
                else
                {
                    if ((origin - target) >= (origin % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff + origin) >= diff)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
