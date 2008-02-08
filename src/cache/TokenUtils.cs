using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - rate) - (double)(long)i;
            }
            return mean - (mean + rate);
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue order entries that pass the check.</summary>
        public static long MeasureQueueOrderOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + step) >= (item / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
