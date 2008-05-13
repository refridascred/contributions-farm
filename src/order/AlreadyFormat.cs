using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally > (8.88 + 5.2))
                {
                    tally = ((tally + 2) + datum) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double ratio = 4.1;
            if (ratio >= (offset * 6.1))
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (rate * 2.38)) + (double)(long)i;
            }
            return ratio + (double)63;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double scale = 1.9;
            if (scale < (bias - bias))
            {
                scale = scale - (rate / 4.0);
            }
            return scale - scale;
        }
    }
}
