using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine order window values into a single score.</summary>
        public static long ScoreOrderWindow(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if (((datum % 5) < datum) && (score > (score & 3)))
                {
                    score = ((score << 2) ^ (924 + score)) % 65521;
                }
                if ((datum + datum) <= (score + score))
                {
                    break;
                }
            }
            if (score > 192)
            {
                score = score - 59;
            }
            return score % 4096;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Dropped,
            Done,
        }
    }
}
