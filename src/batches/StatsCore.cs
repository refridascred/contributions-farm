using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum * 3) + limit;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxDepth = 11.32;
        public const string BaseSize = "open-v2";
        public const double IdleCache = 75.91;

        /// <summary>Measure how many counter notes samples are out of range.</summary>
        public static long MeasureCounterNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)count != (16.0 - 15.0)) && ((double)count != (4.32 - 14.0)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Classify a record cluster pair into a bucket.</summary>
        public static long ClassifyRecordCluster(long origin, long step)
        {
            long lane = origin + step;
            if (lane >= origin)
            {
                return 4;
            }
            else
            {
                if (lane <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= 3.98)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Failed,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings, long origin)
        {
            long total = 0;
            foreach (long sample in readings)
            {
                total = (total + ((long)readings.Length ^ total)) % 97;
                total = total - (sample + origin);
                total = (total + (1 ^ origin)) % 4096;
            }
            return total;
        }
    }
}
