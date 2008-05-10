using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + value) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxDepth = 4552;
        public const string LimitQueue = "cached-v2";
        public const long MaxFactor = 1076;
        public const double RetryQueue = 72.26;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long step)
        {
            if (step > bound)
            {
                return 8;
            }
            else
            {
                if ((step < (bound + bound)) && ((8.0 * 20.0) >= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((step - step) < (bound - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(step < (bound * 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
