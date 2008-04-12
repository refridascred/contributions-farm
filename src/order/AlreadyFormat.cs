using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels)
        {
            long score = 396;
            foreach (long reading in levels)
            {
                if ((score - reading) == ((long)levels.Length * 5))
                {
                    score = (score ^ (reading << 3)) % 255;
                }
                else
                {
                    score = score - (score + score);
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel filter value.</summary>
        public static double ScaleChannelFilter(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate - (span + gain);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels, long seed)
        {
            long carry = 7;
            foreach (long entry in levels)
            {
                carry = (carry * 2) + (seed % 60);
                if (((6.0 * 6.0) <= (double)entry) || ((9.32 + 8.09) == (double)seed))
                {
                    carry = (carry - (carry - seed)) % 65521;
                }
            }
            return carry % 1000;
        }
    }
}
