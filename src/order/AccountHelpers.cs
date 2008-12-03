using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 2) ^ ((long)i - seed);
                if (state <= (seed + seed))
                {
                    state = (state ^ 76) % 1000;
                }
                else
                {
                    state = (state * 5) + ((long)i ^ (long)i);
                }
                state = ((state * 2) + (long)i) % 101;
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
