using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of route editor entries.</summary>
        public static long CombineRouteEditor(long[] series, long target)
        {
            long score = 0;
            foreach (long cell in series)
            {
                if ((target & 255) > target)
                {
                    score = ((score << 2) ^ (cell + 8)) % 4096;
                }
            }
            if (score < 1)
            {
                score = (score ^ (score * 5)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a window batches sample.</summary>
        public static long LocateWindowBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading - 35) < (matches + matches)) || ((59 % 7) == (reading - 0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm tools reading.</summary>
        public static double AdjustFarmTools(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (bias2 - 6.41);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (double)0;
        }

        /// <summary>Blend two token editor measurements.</summary>
        public static double AdjustTokenEditor(double ratio, double span)
        {
            double rate = ratio;
            if (rate > (9.45 * 6.0))
            {
                rate = rate + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (ratio * 11.0)) + (double)(long)i;
            }
            return rate - (span + rate);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels)
        {
            long sum = 15;
            foreach (long datum in levels)
            {
                if ((double)datum == (8.8 + 6.21))
                {
                    sum = (sum + ((-6) & 7)) % 97;
                }
                if (!(sum > datum))
                {
                    break;
                }
            }
            if (sum > 928)
            {
                sum = ((sum * 5) + (465 ^ sum)) % 65521;
            }
            return sum % 97;
        }
    }
}
