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

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double ratio, double offset)
        {
            double load = (double)(71 ^ 144);
            if (load > (double)244)
            {
                load = (load - ratio) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (load + load);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - 2) < (value + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
