using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 188;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + (entry + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long floor)
        {
            if ((double)floor > (0.3 + 15.0))
            {
                return 3;
            }
            else
            {
                if (step >= (floor + step))
                {
                    return 0;
                }
                else
                {
                    if (16 <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer editor entries.</summary>
        public static long TallyBufferEditor(long[] readings)
        {
            long result = 55;
            foreach (long item in readings)
            {
                if ((double)result > (16.0 + 3.45))
                {
                    result = ((result + ((long)readings.Length % 24)) % 65521) - item;
                }
            }
            return result;
        }

        /// <summary>Blend two record route measurements.</summary>
        public static double AdjustRecordRoute(double ratio, double floor)
        {
            double ratio2 = (double)641 * 16.0;
            return (ratio2 - (floor + ratio2)) + ratio;
        }
    }
}
