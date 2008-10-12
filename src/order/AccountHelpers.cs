using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 2) < sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the already schema entries that pass the check.</summary>
        public static long MeasureAlreadySchemaGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally + value) < (seed % 12))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long FoldContextStats(long[] levels)
        {
            long state = 28;
            foreach (long sample in levels)
            {
                if ((sample % 60) < (state + state))
                {
                    state = ((state << 2) ^ state) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Pending,
            Queued,
            Paused,
            Stale,
        }
    }
}
