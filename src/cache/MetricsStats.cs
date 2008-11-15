using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long CombineGithubfarmReport(long[] readings, long target)
        {
            long carry = 364;
            foreach (long sample in readings)
            {
                if ((carry ^ sample) >= (carry % 2))
                {
                    carry = (carry - (target - sample)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the githubfarm checks series from a seed.</summary>
        public static long DeriveGithubfarmChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = score ^ (score + limit);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
