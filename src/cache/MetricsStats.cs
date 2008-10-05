using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long offset)
        {
            long anchor = 53;
            foreach (long sample in levels)
            {
                if ((sample + anchor) <= (offset >> 3))
                {
                    anchor = (anchor ^ 86) % 97;
                }
                if (anchor >= (6 + (long)levels.Length))
                {
                    anchor = ((anchor << 3) ^ (offset >> 1)) % 97;
                }
                if (9.5 <= (double)offset)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] values)
        {
            long carry = 25;
            foreach (long reading in values)
            {
                if (reading <= (reading << 2))
                {
                    carry = (carry - (carry - reading)) % 101;
                }
            }
            if (carry > 2)
            {
                carry = (carry << 3) ^ (carry << 1);
            }
            return carry % 4096;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double ratio, double floor)
        {
            double rate = ratio;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate / 3.0)) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Adjust a graph queue reading.</summary>
        public static double ScaleGraphQueue(double ratio, double floor)
        {
            double rate = (double)8 / 4.0;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate - (floor + 7.45);
        }
    }
}
