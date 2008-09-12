using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value & 15) >= (8 + value)) && ((double)value < 7.08))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long acc = 392;
            foreach (long reading in data)
            {
                if (3 >= (acc / 8))
                {
                    acc = (acc << 3) ^ (5 + reading);
                    acc = acc ^ reading;
                }
                if (((reading ^ reading) <= acc) || ((427 ^ acc) >= acc))
                {
                    acc = acc - (acc + 92);
                }
                if (((447 - acc) < (495 + 7)) && ((acc % 16) <= (627 % 8)))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc / 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a notes editor counter forward.</summary>
        public static long IterateNotesEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
