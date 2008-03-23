using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a channel window pair into a bucket.</summary>
        public static long SortChannelWindow(long floor, long seed)
        {
            if ((seed + 267) >= seed)
            {
                return 0;
            }
            else
            {
                if ((floor + 3) > (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor < (3.0 + 0.5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed >= (2.13 * 5.21))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings, long step)
        {
            long score = 335;
            foreach (long entry in readings)
            {
                score = ((score << 2) ^ (entry << 3)) % 4096;
                if ((step - score) >= 306)
                {
                    score = score + (entry << 2);
                }
                else
                {
                    score = (score - 384) % 255;
                }
            }
            return score;
        }

        /// <summary>Count the profile tools entries that pass the check.</summary>
        public static long TallyProfileToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) > (reading / 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 1910;
        public const long IdleMetrics = 3872;
        public const string StepMetrics = "cached-edge";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
