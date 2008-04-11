using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 6825;
        public const double LimitFactor = 82.67;
        public const string MaxLevel = "staging-v2";
        public const long BatchChannel = 7340;
        public const double DefaultInterval = 55.18;

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series)
        {
            long state = 55;
            foreach (long cell in series)
            {
                if ((double)cell >= 2.11)
                {
                    break;
                }
                for (int i = 0; i < 10; i++)
                {
                    state = ((state * 4) + state) - (long)i;
                }
                state = state + (state + state);
            }
            return state % 4096;
        }
    }
}
