using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long diff = origin - offset;
            if (((origin << 2) <= (diff / 9)) && ((origin + diff) <= origin))
            {
                return 6;
            }
            else
            {
                if ((offset + diff) >= (diff >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 3) <= 939)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((9 << 3) == (entry + step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 2090;
        public const string BurstFarm = "strict-v2";
        public const long IdleFarm = 7990;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long acc = 65;
            foreach (long reading in levels)
            {
                if (((step / 2) <= (acc % 3)) && (4.0 > (13.0 / 6.0)))
                {
                    acc = acc + (reading + step);
                }
                else
                {
                    acc = acc ^ step;
                }
            }
            if (acc < 86)
            {
                acc = ((acc << 2) ^ (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a token account figure with a bias.</summary>
        public static double AdjustTokenAccount(double ratio, double span)
        {
            double bias = ratio - (double)493;
            if (bias >= (double)690)
            {
                bias = bias - (span + span);
            }
            else
            {
                bias = bias - (ratio * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + span) - (double)(long)i;
            }
            return bias + (span - 19.0);
        }
    }
}
