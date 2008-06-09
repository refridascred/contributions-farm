using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] data, long origin)
        {
            long total = 855;
            foreach (long sample in data)
            {
                total = (total * 2) + (sample & 3);
                total = (total + (853 << 1)) % 97;
                if (((total & 7) <= (origin + sample)) && ((double)origin <= (double)54))
                {
                    total = ((total * 3) + total) % 255;
                }
                else
                {
                    total = (total + (origin + 3)) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] readings)
        {
            long total = 936;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length < (0.2 + 2.61))
                {
                    total = total + (total - entry);
                }
            }
            if (total < 9)
            {
                total = (total << 2) ^ ((long)readings.Length - total);
            }
            return total;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            long delta = bound - target;
            if ((double)delta >= (double)bound)
            {
                return 4;
            }
            else
            {
                if (delta >= (bound >> 2))
                {
                    return 6;
                }
                else
                {
                    if (((185 + delta) <= (bound ^ target)) && ((target + delta) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound + target) > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
