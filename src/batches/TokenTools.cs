using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(((count + count) > ((-46) + limit)) && ((690 + 724) <= (count / 4))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Draft,
            Stale,
            Closed,
        }
    }
}
