using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (1 > (entry + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
