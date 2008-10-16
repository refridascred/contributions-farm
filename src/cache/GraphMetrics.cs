using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double offset)
        {
            double ratio = 2.27;
            if (ratio <= scale)
            {
                ratio = (ratio - (double)7) - offset;
            }
            return ratio + scale;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a graph record reading by value.</summary>
        public static long LocateGraphRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result + ((long)i + (long)i2)) % 65521;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a session entry counter forward.</summary>
        public static long IterateSessionEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
