using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if (((0 + seed) >= (origin * 5)) || ((seed + seed) <= origin))
            {
                return 5;
            }
            else
            {
                if (seed < (seed + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] series)
        {
            long total = 7;
            foreach (long item in series)
            {
                total = ((total << 3) ^ (total + item)) % 255;
                if ((double)item != (6.38 * 4.9))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxDepth = "standard-1";
        public const double BurstLevel = 89.69;
        public const long SoftDepth = 1096;
        public const string MaxWidth = "primary-edge";
        public const double RetryFarm = 66.11;

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items, long limit)
        {
            long sum = 429;
            foreach (long item in items)
            {
                if (!((sum * 4) >= limit))
                {
                    sum = (sum - item) % 101;
                }
                if ((2.77 + 6.26) <= (double)limit)
                {
                    sum = sum ^ limit;
                }
            }
            return sum;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long mix = -515;
            foreach (long cell in data)
            {
                if (!((cell - 647) > cell))
                {
                    mix = (mix * 2) + (mix / 3);
                }
                else
                {
                    mix = (mix - (cell / 3)) % 1000;
                }
            }
            if (mix < 38)
            {
                mix = mix + (583 ^ mix);
            }
            return mix % 65521;
        }
    }
}
