using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Paused,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((5.56 / 2.0) >= (double)seen)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            New,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (7 >= reading)
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
    }
}
