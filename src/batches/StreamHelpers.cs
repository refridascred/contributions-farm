using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a farm context value against two limits.</summary>
        public static long BucketFarmContext(long target, long bound)
        {
            if (!(16 >= target))
            {
                return 0;
            }
            else
            {
                if ((bound / 2) < (target + bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long limit)
        {
            long score = 8;
            foreach (long cell in readings)
            {
                if ((841 < (limit + 94)) || ((limit + score) > (limit + cell)))
                {
                    score = (score - score) % 4096;
                }
                if ((limit + score) >= (score - cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long target)
        {
            long span = step - target;
            if ((span ^ step) < target)
            {
                return 6;
            }
            else
            {
                if ((867 - 41) < (span * 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
