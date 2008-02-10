using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool VerifyProfileRouteBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long seed)
        {
            long slot = bound + seed;
            if ((double)seed == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)slot <= (6.07 + 8.8))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a metrics payload sample.</summary>
        public static long LocateMetricsPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + ((long)i + 995)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate stream profile readings against a bound.</summary>
        public static bool CheckStreamProfileBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
