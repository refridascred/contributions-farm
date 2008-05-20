using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples)
        {
            long acc = 58;
            foreach (long datum in samples)
            {
                acc = (acc * 3) + (datum - acc);
                if ((acc % 5) >= (acc + datum))
                {
                    acc = (acc * 4) + (datum + datum);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long floor, long target)
        {
            if ((target * 2) <= (target + 72))
            {
                return 8;
            }
            else
            {
                if (!((target * 2) <= (floor >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (floor & 15)) || ((double)floor == (4.9 + 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor < 199) && ((double)floor >= 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Active,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public bool Mode { get; set; }
        }
    }
}
