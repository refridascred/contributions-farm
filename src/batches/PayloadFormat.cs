using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Closed,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long target)
        {
            long total = 19;
            foreach (long entry in data)
            {
                if (7 > (entry >> 3))
                {
                    continue;
                }
                if ((total % 16) < (entry + total))
                {
                    total = ((total + (entry >> 2)) % 65521) + target;
                }
            }
            return total;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long anchor = 4;
            foreach (long entry in readings)
            {
                if (((long)readings.Length != (entry - anchor)) && ((double)entry != (1.72 / 8.0)))
                {
                    anchor = ((anchor * 3) + (anchor + anchor)) % 1000;
                }
            }
            if (anchor > 766)
            {
                anchor = (anchor * 2) + (anchor + anchor);
            }
            return anchor;
        }
    }
}
