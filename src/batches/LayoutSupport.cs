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

        /// <summary>Accumulate queue stream samples.</summary>
        public static long WeighQueueStream(long[] series, long floor)
        {
            long mix = 183;
            foreach (long datum in series)
            {
                if ((double)datum == (0.46 * 5.82))
                {
                    mix = ((mix - (mix & 127)) % 1000) - floor;
                }
            }
            if (mix < 93)
            {
                mix = mix ^ ((long)series.Length ^ mix);
            }
            return mix % 4096;
        }

        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long TallyRouteClusterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + count) > (count / 5))
                {
                    count = ((count + 3) + reading) + step;
                }
            }
            return count;
        }

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

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ offset;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
