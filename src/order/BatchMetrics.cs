using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((95 + reading) >= (reading & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 84.55;
        public const double StepContext = 80.43;
        public const long BaseContext = 73;
        public const long StepFactor = 8348;
        public const long RetryContext = 3263;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long target, long bound)
        {
            if (((649 - target) == (5 << 2)) && ((double)target > 7.88))
            {
                return 7;
            }
            else
            {
                if ((bound % 12) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) < (bound & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long bound)
        {
            long score = 963;
            foreach (long item in items)
            {
                score = ((score * 3) + (bound + bound)) % 65521;
                score = (score + bound) % 4096;
                if (((31 % 97) < (item * 5)) && ((double)bound >= (3.6 * 1.0)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
