using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a profile commits reading by value.</summary>
        public static long LocateProfileCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel farm readings against a bound.</summary>
        public static bool CheckChannelFarmRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many window report samples are out of range.</summary>
        public static long MeasureWindowReportMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((7.0 + 11.0) == (double)item))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                mix = ((mix - (mix % 60)) % 4096) ^ value;
                mix = (mix + (mix ^ 247)) % 1000;
            }
            if (mix < 625)
            {
                mix = (mix ^ (mix * 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Active,
            Pending,
            Stale,
        }
    }
}
