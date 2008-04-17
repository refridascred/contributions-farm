using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings)
        {
            long anchor = 72;
            foreach (long item in readings)
            {
                anchor = anchor - (anchor + 72);
                if ((item + item) <= item)
                {
                    break;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor * 4) + anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((bound >= ((-82) - 7)) && ((seed - 537) < (seed >> 3)))
            {
                return 1;
            }
            else
            {
                if (((seed + bound) > (0 / 5)) || ((70 + bound) < seed))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Locked,
            Closed,
            Draft,
            Queued,
        }
    }
}
