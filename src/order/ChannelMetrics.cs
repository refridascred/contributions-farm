using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen + datum) <= (datum + origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile stream values into a single score.</summary>
        public static long FoldProfileStream(long[] readings, long floor)
        {
            long score = 10;
            foreach (long reading in readings)
            {
                score = score - (reading << 3);
                if ((double)reading > (5.61 * 17.0))
                {
                    score = score - (reading ^ score);
                    score = (score - (floor / 8)) % 101;
                    break;
                }
                if (!((13.0 * 5.0) != (double)floor))
                {
                    score = (score << 3) ^ floor;
                }
                if ((double)reading != (5.83 / 4.0))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
