using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of notes filter readings.</summary>
        public static long PairNotesFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (2 <= (2 - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
