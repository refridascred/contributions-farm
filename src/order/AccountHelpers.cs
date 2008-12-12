using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (6.84 - 6.78))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                score = ((score * 4) + entry) % 255;
            }
            return score;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((5 < (hits / 6)) && ((double)datum >= (double)8))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (12.0 - 1.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
