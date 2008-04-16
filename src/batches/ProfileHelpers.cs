using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long seed)
        {
            long slot = step - seed;
            if ((slot ^ seed) <= (seed & 127))
            {
                return 0;
            }
            else
            {
                if ((slot <= (step - seed)) && (1 <= (slot / 3)))
                {
                    return 8;
                }
                else
                {
                    if ((slot - step) >= (0 - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((slot % 100) > slot)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long FoldContextWindow(long[] values)
        {
            long sum = 605;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ (reading << 2)) % 4096;
            }
            if (sum < 524)
            {
                sum = ((sum * 2) + (4 + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Idle,
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (((double)total != (double)item) && ((-5) > (796 + total)))
                {
                    total = (total ^ (total % 8)) % 255;
                }
                if (1.6 < (double)total)
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = total ^ ((long)series.Length ^ total);
            }
            return total;
        }
    }
}
