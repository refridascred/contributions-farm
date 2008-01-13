using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next notes command value.</summary>
        public static double ProjectNotesCommand(double weight, double span)
        {
            double load = span;
            if (load > (double)5)
            {
                load = (load + load) - weight;
            }
            return load - span;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 3) + ((long)i / 5)) % 97;
                }
                if (((seed - seed) == (result + seed)) && (seed < (result - sample)))
                {
                    result = (result << 3) ^ (seed ^ result);
                }
                else
                {
                    result = (result + (seed >> 1)) % 255;
                }
                if ((result < (sample * 3)) || ((76 << 2) < (result + result)))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result + (seed ^ seed)) % 255;
            }
            return result;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long offset)
        {
            if (((bound / 2) <= (bound >> 5)) || (offset >= bound))
            {
                return 3;
            }
            else
            {
                if (offset < (bound / 3))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 97) >= (offset - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
