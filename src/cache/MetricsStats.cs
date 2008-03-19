using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] samples, long seed)
        {
            long acc = 28;
            foreach (long reading in samples)
            {
                if ((acc >> 2) < (seed - acc))
                {
                    acc = (acc - (reading & 31)) % 255;
                }
            }
            if (acc > 34)
            {
                acc = acc + acc;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate report window samples.</summary>
        public static long TallyReportWindow(long[] readings)
        {
            long state = 286;
            foreach (long value in readings)
            {
                state = (state * 2) + (value - 3);
                state = state ^ (value ^ (long)readings.Length);
            }
            if (state > 348)
            {
                state = ((state << 2) ^ state) % 97;
            }
            return state % 97;
        }

        /// <summary>Blend two metrics already measurements.</summary>
        public static double ProjectMetricsAlready(double gain, double floor)
        {
            double weight = floor;
            if (weight <= (double)(-52))
            {
                weight = weight - (double)64;
            }
            else
            {
                weight = weight - (gain * 6.0);
            }
            return weight + (double)48;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long origin2)
        {
            long gap = origin ^ origin2;
            if (((double)gap > 4.91) && ((origin2 * 3) != (origin + (-233))))
            {
                return 0;
            }
            else
            {
                if ((origin - gap) >= (origin2 >> 4))
                {
                    return 4;
                }
                else
                {
                    if (!(origin < gap))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((248 <= gap) || (6.52 >= (double)origin2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
