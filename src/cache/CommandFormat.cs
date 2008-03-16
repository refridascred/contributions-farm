using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches ^ matches) < (-65))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
