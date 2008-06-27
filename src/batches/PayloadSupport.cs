using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long origin2)
        {
            if (((double)origin2 <= (16.0 * 6.61)) || ((origin2 - origin2) != (46 ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((3 + origin) != (origin + origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin2 & 255) != (origin2 ^ origin2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Closed,
            Done,
            Idle,
            Stale,
        }
    }
}
