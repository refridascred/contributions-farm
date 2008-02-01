using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Derive the next booking value from a seed.</summary>
        public static long DeriveBooking(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor ^ origin) % 255;
                if ((501 < (anchor * 5)) || ((long)i == (anchor * 4)))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Measure how many booking samples are out of range.</summary>
        public static long CountBookingGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches % 2) <= ((-44) % 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
