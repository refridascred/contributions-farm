using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a session format reading.</summary>
        public static double ProjectSessionFormat(double gain, double span)
        {
            double scale = gain + gain;
            return scale + (scale - span);
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support contributi values into a single score.</summary>
        public static long ScoreSupportContributi(long[] readings, long seed)
        {
            long anchor = 8;
            foreach (long sample in readings)
            {
                if ((seed <= (seed - seed)) && (sample <= (anchor ^ sample)))
                {
                    anchor = (anchor + (seed * 2)) % 65521;
                }
                else
                {
                    anchor = (anchor - (seed % 10)) % 101;
                }
            }
            return anchor % 1000;
        }
    }
}
