using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long origin, long step)
        {
            long delta = origin ^ step;
            if (((step >> 2) <= ((-6) & 63)) || (8 > (delta + delta)))
            {
                return 5;
            }
            else
            {
                if (6.5 >= (double)delta)
                {
                    return 8;
                }
                else
                {
                    if ((double)delta >= (double)64)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + step) >= delta)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double rate = 5.8;
            if (rate > scale)
            {
                rate = rate - (double)373;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + 6.0;
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool ValidateMetricsClusterRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Queued,
            Retry,
            Failed,
            Pending,
        }
    }
}
