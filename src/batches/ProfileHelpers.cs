using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double mean = 8.93;
            if (mean >= (3.77 + ratio))
            {
                mean = mean + (span - 3.8);
            }
            else
            {
                mean = mean + 2.0;
            }
            return mean + span;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if (((offset3 / 7) >= (offset % 5)) && (offset < offset2))
            {
                return 5;
            }
            else
            {
                if ((5.86 >= (double)offset2) && ((offset3 * 3) > offset3))
                {
                    return 4;
                }
                else
                {
                    if ((((-25) % 2) < (offset + offset)) && ((offset2 - offset2) < 99))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset >= (double)offset3) || ((offset3 ^ offset2) <= offset3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile batches readings.</summary>
        public static long OverlapProfileBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Active,
            New,
            Done,
        }

        /// <summary>Match up filter editor samples.</summary>
        public static long CompareFilterEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long bound)
        {
            if ((7.65 + 18.0) <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound & 7) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
