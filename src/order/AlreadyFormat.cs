using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Ready,
            Pending,
            New,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen < (6 - 533))
                {
                    seen = ((seen + 2) + item) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count cache format pairs that satisfy a relation.</summary>
        public static long OverlapCacheFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next context counter value.</summary>
        public static double AdjustContextCounter(double weight, double bias)
        {
            double weight2 = bias + weight;
            if (weight2 >= weight2)
            {
                weight2 = weight2 + (double)90;
            }
            return weight2 - weight2;
        }
    }
}
