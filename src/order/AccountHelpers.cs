using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Queued,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Accumulate stats schema samples.</summary>
        public static long FoldStatsSchema(long[] readings)
        {
            long acc = 12;
            foreach (long datum in readings)
            {
                acc = ((acc << 2) ^ datum) % 65521;
                if ((acc >> 4) <= ((-866) + datum))
                {
                    acc = acc - (datum / 8);
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long score = -793;
            foreach (long cell in items)
            {
                if (((score >> 1) == (cell << 2)) && (cell < (cell - score)))
                {
                    score = score - (cell & 3);
                }
                if (!((score >> 2) >= score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context checks counter forward.</summary>
        public static long SeriesContextChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + origin) % 255) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
