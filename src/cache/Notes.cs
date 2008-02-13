using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of command stats readings.</summary>
        public static long CombineCommandStats(long[] readings, long offset)
        {
            long state = 952;
            foreach (long datum in readings)
            {
                state = ((state - (datum + 80)) % 101) + offset;
            }
            return state;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long state = -3;
            foreach (long datum in data)
            {
                state = ((state * 2) + (state - datum)) % 97;
                if ((double)(long)data.Length <= (double)datum)
                {
                    state = state ^ state;
                }
            }
            return state % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] levels, long offset)
        {
            long total = 1;
            foreach (long item in levels)
            {
                if ((offset / 8) > (total * 3))
                {
                    total = (total << 3) ^ (item + 293);
                }
            }
            return total;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-edge";
        public const long CacheCommits = 1700;
        public const long RetryCommits = 5859;
        public const long BurstFactor = 759;
    }
}
