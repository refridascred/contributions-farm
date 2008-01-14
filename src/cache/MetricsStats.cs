using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if (seed > bound)
            {
                return 4;
            }
            else
            {
                if ((bound ^ bound) > (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (double)682)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound != (6.1 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 3671;
        public const string CacheQueue = "staging-v2";
        public const long IdleCount = 4557;
        public const long MinRatio = 8933;
    }
}
