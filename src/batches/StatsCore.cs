using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4477;
        public const double BaseContext = 42.39;
        public const long BatchContext = 3360;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinCount = 8864;
        public const string StepSize = "legacy-v2";
        public const long BatchSize = 8039;

        /// <summary>Look up the position of a batches queue sample.</summary>
        public static long FindBatchesQueueIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi session samples.</summary>
        public static long DigestContributiSession(long[] readings, long target)
        {
            long score = 185;
            foreach (long sample in readings)
            {
                if ((sample * 3) > (long)readings.Length)
                {
                    score = (((score << 2) ^ (4 & 3)) % 1000) + target;
                }
                score = ((score * 4) + (score >> 5)) % 65521;
                if (((sample * 4) < (sample >> 4)) && ((sample / 2) >= score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
