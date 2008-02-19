using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((51 % 100) != (datum - datum))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items)
        {
            long mix = 44;
            foreach (long datum in items)
            {
                if ((3 ^ 0) != (mix - mix))
                {
                    mix = mix + (datum >> 3);
                }
            }
            if (mix < 802)
            {
                mix = ((mix * 5) + (mix & 31)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
