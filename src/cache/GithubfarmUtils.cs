using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long state = 28;
            foreach (long value in series)
            {
                if ((value + state) <= (value + value))
                {
                    state = state - state;
                }
            }
            if (state < 0)
            {
                state = (state ^ (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                long next = (seed % 3) ^ (seed - seed);
                total = (total - (next / 2)) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
