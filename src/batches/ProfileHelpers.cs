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

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double ratio, double offset)
        {
            double weight = (double)9 - (ratio - offset);
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (9.6 - ratio)) - (double)(long)i;
            }
            return weight + (weight - 3.47);
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long origin, long step)
        {
            if (!(origin <= 6))
            {
                return 3;
            }
            else
            {
                if ((origin & 7) > (step ^ 3))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double gain, double offset)
        {
            double bias = 8.5;
            return ((bias - (double)89) + gain) + offset;
        }
    }
}
