using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up context buffer samples.</summary>
        public static long OverlapContextBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
