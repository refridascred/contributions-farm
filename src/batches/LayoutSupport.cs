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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 2) <= (entry ^ count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
