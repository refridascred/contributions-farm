using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (125 > (sample << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
