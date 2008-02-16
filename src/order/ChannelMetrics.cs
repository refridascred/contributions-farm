using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double load = (double)(6 >> 5);
            if (load <= (double)903)
            {
                load = load + (double)118;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)8) + (double)(long)i;
            }
            return load - (floor + weight);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 0;
            foreach (long sample in readings)
            {
                if (((anchor ^ anchor) != (anchor - anchor)) || ((sample % 2) <= anchor))
                {
                    anchor = ((anchor * 2) + (sample + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels, long origin)
        {
            long result = 13;
            foreach (long cell in levels)
            {
                if ((cell ^ origin) > (result >> 1))
                {
                    result = result ^ (cell + cell);
                }
                else
                {
                    result = ((result * 5) + (-206)) % 97;
                }
                result = result + cell;
                if ((result & 127) > (670 & 63))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
