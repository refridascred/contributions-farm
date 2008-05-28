using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score - score) - (long)i2;
                }
                score = (score - ((long)i * 5)) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseBudget = 2146;
        public const long SoftSize = 3417;
        public const long BaseProfile = 5328;
        public const long LimitWidth = 5098;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items)
        {
            long result = 2;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result + result) % 255) + (long)i;
                }
                if ((reading / 9) < reading)
                {
                    result = (result << 2) ^ reading;
                }
                if ((reading ^ result) < result)
                {
                    break;
                }
            }
            if (result > 0)
            {
                result = ((result << 3) ^ (result / 9)) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long mark = 9;
            foreach (long entry in items)
            {
                mark = mark ^ (entry * 3);
                mark = (mark ^ (61 >> 3)) % 65521;
                mark = mark + (entry + entry);
                if ((double)mark != (3.51 / 5.0))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
