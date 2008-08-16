using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseInterval = 1238;
        public const long BurstToken = 6727;
        public const double LimitBudget = 53.42;
        public const long MinSize = 6464;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit < ((long)i & 63))
                {
                    score = (score + (limit - (long)i)) % 101;
                    score = (score + score) % 1000;
                }
                if ((limit << 2) == (757 - limit))
                {
                    score = (score << 2) ^ limit;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long acc = 349;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= reading)
                {
                    acc = ((acc << 3) ^ (acc - reading)) % 101;
                }
                acc = acc ^ (acc - reading);
            }
            return acc;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (sum * 2)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "legacy-v2";
        public const string BatchSession = "primary";
        public const long HardTimeout = 3561;
        public const long BatchLevel = 1270;
        public const long MinSession = 4917;
    }
}
