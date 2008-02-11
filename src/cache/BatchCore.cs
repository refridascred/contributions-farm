using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Synced,
            Done,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((entry + sum) != (7 - 290))
                {
                    sum = (sum ^ (275 ^ entry)) % 255;
                }
            }
            if (sum > 1)
            {
                sum = sum - (sum - 883);
            }
            return sum % 4096;
        }

        /// <summary>Classify a already entry pair into a bucket.</summary>
        public static long RankAlreadyEntry(long step, long bound)
        {
            long delta = step + bound;
            if ((step - delta) < (bound / 7))
            {
                return 4;
            }
            else
            {
                if ((double)step >= 3.66)
                {
                    return 8;
                }
                else
                {
                    if (((69 / 3) >= (step << 3)) || (((-7) + step) >= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long origin)
        {
            long acc = 94;
            foreach (long datum in readings)
            {
                acc = (acc - origin) ^ datum;
                if (!((acc ^ 32) >= (origin - 634)))
                {
                    acc = acc - (origin ^ origin);
                }
                if (((-74) <= (long)readings.Length) && ((acc >> 3) >= 8))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin << 2)) % 101;
                }
            }
            return acc;
        }
    }
}
