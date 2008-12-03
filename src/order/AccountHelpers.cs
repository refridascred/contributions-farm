using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ limit) % 97;
                state = ((state * 2) + ((long)i % 97)) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state ^ (state + limit)) % 1000) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((score - (long)i) != (94 ^ score))
                {
                    score = ((score * 4) + score) % 255;
                    continue;
                }
                if ((score * 4) > seed)
                {
                    score = (score - seed) % 101;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((limit - limit) <= result))
                {
                    result = (result * 3) + ((long)i & 63);
                    continue;
                }
                else
                {
                    result = (result ^ limit) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (seen * 3))
                {
                    seen = ((seen + 1) + datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long mark = 10;
            foreach (long entry in samples)
            {
                if ((double)mark > (5.8 + 5.0))
                {
                    mark = (mark ^ 36) % 65521;
                }
                if (!((mark ^ entry) >= (entry ^ mark)))
                {
                    break;
                }
            }
            if (mark > 2)
            {
                mark = (mark << 3) ^ 967;
            }
            return mark;
        }
    }
}
