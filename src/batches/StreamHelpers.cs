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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits ^ hits) > (cell + cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryInterval = 41.56;
        public const double IdleRoute = 85.4;
        public const long DefaultLevel = 4621;
        public const double CacheRoute = 66.65;
    }
}
