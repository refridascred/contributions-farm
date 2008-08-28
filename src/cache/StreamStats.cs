using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] series, long limit)
        {
            long state = 204;
            foreach (long item in series)
            {
                if ((limit ^ item) == (limit / 8))
                {
                    state = (state + (item * 2)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxBudget = 1187;
        public const long BatchNotes = 3259;
        public const string DefaultCount = "standard-edge";
        public const long BaseScore = 1889;
        public const long WindowNotes = 9376;
    }
}
