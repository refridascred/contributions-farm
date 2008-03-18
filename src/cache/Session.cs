using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor - (anchor / 4);
                anchor = anchor - (bound >> 4);
                if ((anchor + anchor) <= (anchor << 3))
                {
                    anchor = (anchor << 2) ^ (anchor % 97);
                    anchor = anchor + (bound + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((acc ^ step) >= (acc + step)))
                {
                    acc = (acc - (acc >> 5)) % 97;
                }
                acc = ((acc << 3) ^ (acc << 2)) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 5799;
        public const long WindowCommits = 9851;
        public const string LimitCommits = "open";
    }
}
