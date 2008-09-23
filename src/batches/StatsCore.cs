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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long DigestClusterCounter(long[] series)
        {
            long carry = 345;
            foreach (long value in series)
            {
                if ((carry > (carry - value)) || (value > (value ^ carry)))
                {
                    carry = carry ^ (752 >> 4);
                }
                carry = (carry - (carry & 7)) % 101;
            }
            return carry % 4096;
        }
    }
}
