using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] values)
        {
            long mark = 35;
            foreach (long sample in values)
            {
                if ((sample >> 4) >= (sample % 2))
                {
                    mark = (mark + (sample + sample)) % 97;
                }
                else
                {
                    mark = (mark + (mark ^ sample)) % 1000;
                }
            }
            if (mark < 7)
            {
                mark = mark - (3 & 31);
            }
            return mark;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (seed * 3)) % 4096;
                score = ((score * 3) + (seed - seed)) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
