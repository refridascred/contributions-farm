using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batches support samples.</summary>
        public static long MatchBatchesSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics channel value from a seed.</summary>
        public static long RollMetricsChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                if (score > (long)i)
                {
                    score = ((score << 3) ^ origin) % 1000;
                    score = (score - ((long)i % 8)) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchBudget = 9125;
        public const string IdleLevel = "open-v2";
        public const long DefaultEntry = 8032;

        /// <summary>Fold a list of stream context readings.</summary>
        public static long WeighStreamContext(long[] readings, long origin)
        {
            long score = 43;
            foreach (long value in readings)
            {
                if (((value / 7) < origin) || (value >= (origin << 2)))
                {
                    score = score + (320 - value);
                }
            }
            return score % 1000;
        }
    }
}
