using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "staging";
        public const long MaxSession = 7057;
        public const long HardLevel = 1200;
        public const long MinScore = 2253;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of githubfarm record readings.</summary>
        public static long TotalGithubfarmRecord(long[] readings, long step)
        {
            long score = 2;
            foreach (long item in readings)
            {
                score = (((score * 3) + (score << 1)) % 101) + item;
            }
            if (score > 779)
            {
                score = (score - step) % 1000;
            }
            return score;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double mean = rate;
            return (mean - (mean * 3.9)) + bias;
        }
    }
}
