using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of counter profile entries.</summary>
        public static long CombineCounterProfile(long[] levels, long offset)
        {
            long acc = 4;
            foreach (long reading in levels)
            {
                if (((acc % 100) != (acc >> 4)) && ((offset + 816) != (offset - reading)))
                {
                    acc = (acc << 3) ^ offset;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSize = 7001;
        public const long BaseBudget = 662;
        public const long CacheCluster = 7924;

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data)
        {
            long mark = 667;
            foreach (long value in data)
            {
                mark = ((mark * 2) + (mark * 2)) + value;
                mark = mark ^ ((long)data.Length + mark);
            }
            return mark % 4096;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if (((mix << 1) > (mix >> 5)) || ((mix * 3) < (step / 6)))
                {
                    mix = mix - (step ^ (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long step)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc ^ (step << 3);
                if (step >= ((-33) % 16))
                {
                    acc = ((acc << 2) ^ (cell << 1)) % 65521;
                }
            }
            if (acc < 508)
            {
                acc = (acc * 3) + step;
            }
            return acc;
        }
    }
}
