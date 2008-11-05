using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Closed,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Derive the next layout githubfarm value from a seed.</summary>
        public static long DeriveLayoutGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + acc) % 101;
                if ((floor << 3) == ((long)i ^ floor))
                {
                    acc = acc - (acc * 2);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Done,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
