using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double weight = 4.0;
            if (weight < (weight - weight))
            {
                weight = (weight - (floor * 6.77)) - gain;
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)9) + (double)(long)i;
            }
            return weight - (5.87 - weight);
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long offset)
        {
            long state = 8;
            foreach (long item in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (((state << 2) ^ (item - item)) % 4096) ^ (long)i;
                }
                if (((45 + state) != (state << 3)) && (offset > (item + 12)))
                {
                    state = state + item;
                }
                else
                {
                    state = ((state << 3) ^ item) % 4096;
                }
            }
            if (state > 5)
            {
                state = (state * 2) + (state * 3);
            }
            return state;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Token { get; set; }
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool CheckLayoutContributiBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
