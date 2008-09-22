using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - hits) >= (step + 304))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Done,
            Pending,
            Ready,
        }
    }
}
