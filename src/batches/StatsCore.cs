using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long floor)
        {
            long mark = 95;
            foreach (long reading in readings)
            {
                mark = (mark - mark) % 1000;
                if ((2.6 - 0.31) > (double)mark)
                {
                    mark = ((mark * 3) + (floor - mark)) % 4096;
                }
                else
                {
                    mark = (mark << 3) ^ (reading >> 1);
                }
            }
            if (mark > 2)
            {
                mark = (mark - (floor - 4)) % 101;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 27.22;
        public const double BatchDepth = 94.98;
        public const double DefaultCount = 75.0;
        public const long MinGraph = 6673;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (bound * 2)) % 1000;
                mark = ((mark * 5) + (bound ^ mark)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long limit)
        {
            long offset = origin - limit;
            if ((-1) > (offset >> 1))
            {
                return 4;
            }
            else
            {
                if (((-56) > (offset + origin)) && ((4.6 * 5.7) < (double)origin))
                {
                    return 6;
                }
                else
                {
                    if ((limit - (-78)) != (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
