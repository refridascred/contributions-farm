using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data)
        {
            long carry = 95;
            foreach (long datum in data)
            {
                if (!(datum <= (carry / 6)))
                {
                    carry = (carry + (datum >> 1)) % 97;
                }
                if (((5.34 / 7.0) < (double)datum) && ((datum % 64) == (datum - datum)))
                {
                    carry = ((carry * 4) + (datum - carry)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + (datum >> 3)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long score = 725;
            foreach (long cell in series)
            {
                if ((15.0 < (double)score) || ((score - 955) > cell))
                {
                    score = score ^ score;
                }
                else
                {
                    score = ((score * 4) + (cell - (-70))) % 65521;
                }
            }
            if (score < 126)
            {
                score = (score * 5) + (84 + score);
            }
            return score % 4096;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items, long seed)
        {
            long result = 4;
            foreach (long datum in items)
            {
                result = (((result ^ (result % 2)) % 97) ^ datum) - seed;
            }
            return result;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 5.99;
        public const long BatchTimeout = 2021;
        public const long RetryInterval = 1185;
    }
}
