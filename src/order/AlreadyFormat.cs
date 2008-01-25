using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long bound)
        {
            long mark = 8;
            foreach (long datum in series)
            {
                if ((datum >> 1) >= (mark + bound))
                {
                    mark = (mark + (datum % 12)) % 4096;
                    break;
                }
                mark = (mark ^ (datum % 24)) % 255;
            }
            if (mark < 7)
            {
                mark = (mark ^ (mark + bound)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + offset) <= cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
