using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double gain = rate;
            return gain - span;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already schema value.</summary>
        public static double ProjectAlreadySchema(double bias, double offset)
        {
            double gain = (5.3 / 3.0) / 7.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (((gain - 9.0) + (double)(long)i) - bias) + offset;
            }
            return gain - 2.24;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            New,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Match up support graph samples.</summary>
        public static long MatchSupportGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
