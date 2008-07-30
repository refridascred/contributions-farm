using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((acc + acc) >= (limit + acc)) && ((179 % 7) >= (limit - (long)i)))
                {
                    acc = (acc - (acc >> 5)) % 4096;
                    acc = acc ^ limit;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of stats stream entries.</summary>
        public static long FoldStatsStream(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                if (((value * 3) == (score ^ value)) || ((480 + (long)data.Length) <= (score * 4)))
                {
                    score = ((score * 4) + (score % 3)) % 65521;
                }
            }
            if (score > 80)
            {
                score = (score ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long bound, long step)
        {
            if ((step >= (step + step)) || ((double)bound > 10.0))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (1.0 - 9.51))
                {
                    return 6;
                }
                else
                {
                    if (((step + bound) != (step >> 3)) || ((step / 2) != (bound << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstCount = 3.61;
        public const long LimitFactor = 2362;
        public const long LimitReport = 2561;
        public const long BatchCount = 8550;
        public const long SoftReport = 8066;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Queued,
            Failed,
        }
    }
}
