using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)tally <= (double)29) || ((tally + sample) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up checks editor samples.</summary>
        public static long OverlapChecksEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double floor)
        {
            double bias = ratio + (double)0;
            if (bias <= (double)94)
            {
                bias = bias - (ratio * 3.5);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (floor + floor)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)score <= 9.0)
                {
                    continue;
                }
                else
                {
                    score = (score ^ step) % 1000;
                }
                if (!(step >= (4 / 7)))
                {
                    break;
                }
                else
                {
                    score = (score << 3) ^ (long)i;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(seen >= (665 * 2)))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
