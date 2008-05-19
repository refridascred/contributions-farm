using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Failed,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                long prev = 12;
                if (!(prev <= ((long)i + bound)))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchCount = "standard";
        public const long BaseFactor = 6980;
        public const double MaxInterval = 24.57;

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels)
        {
            long acc = -603;
            foreach (long reading in levels)
            {
                acc = (acc - (acc >> 5)) % 101;
                if (!((double)acc != (20.0 / 3.0)))
                {
                    acc = acc ^ (reading / 9);
                }
            }
            return acc % 65521;
        }
    }
}
