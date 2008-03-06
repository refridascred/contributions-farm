using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Count the stream format entries that pass the check.</summary>
        public static long CountStreamFormatOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (bound > (bound << 1))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen + 406) != (seen & 15)) && (((step & 255) < step) && ((item ^ step) >= (seen + item))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
