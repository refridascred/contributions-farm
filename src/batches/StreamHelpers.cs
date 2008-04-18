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

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long limit)
        {
            long mix = 100;
            foreach (long datum in data)
            {
                if (datum > (datum ^ datum))
                {
                    mix = ((mix << 2) ^ (limit - limit)) % 255;
                }
                if (limit > (mix + limit))
                {
                    mix = mix ^ (mix - limit);
                }
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Failed,
            Draft,
            Synced,
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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
