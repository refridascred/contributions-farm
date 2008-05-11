using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((6 > (item - (long)readings.Length)) && !((double)item >= 0.16))
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] levels, long seed)
        {
            long acc = 71;
            foreach (long sample in levels)
            {
                if ((sample % 7) > (seed & 3))
                {
                    acc = acc - (sample % 8);
                    acc = (acc + acc) % 65521;
                }
                acc = (acc << 3) ^ (seed ^ 38);
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= 19.0)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long target)
        {
            long bound = step + target;
            if ((5.0 + 6.2) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (bound < (step % 7))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) <= (target - step))
                    {
                        return 1;
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
