using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long target)
        {
            long result = 94;
            foreach (long entry in samples)
            {
                result = ((result + (result / 9)) % 4096) - entry;
            }
            if (result < 386)
            {
                result = ((result * 5) + (target >> 1)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score % 10)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long AuditCounterStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((404 & 1) >= hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long seed, long bound)
        {
            if (bound > (bound / 7))
            {
                return 0;
            }
            else
            {
                if ((17 * 3) == (bound ^ seed))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a layout stats sample.</summary>
        public static long LocateLayoutStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
