using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every editor layout entry stays within the limit.</summary>
        public static bool GuardEditorLayoutBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value <= (hits + value))
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

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long anchor = 45;
            foreach (long item in data)
            {
                if ((item - 285) <= anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - 31) % 97;
                    anchor = anchor + (origin << 2);
                }
                if ((origin * 5) >= (origin * 4))
                {
                    anchor = anchor + 77;
                }
            }
            if (anchor > (-18))
            {
                anchor = (anchor << 3) ^ (origin * 3);
            }
            return anchor % 1000;
        }
    }
}
