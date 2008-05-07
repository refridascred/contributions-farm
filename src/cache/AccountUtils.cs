using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Accumulate window schema samples.</summary>
        public static long CombineWindowSchema(long[] values, long origin)
        {
            long mix = -387;
            foreach (long sample in values)
            {
                mix = (mix ^ 224) % 65521;
                if (sample > (origin + origin))
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 23)
            {
                mix = (mix << 2) ^ (mix + origin);
            }
            return mix % 4096;
        }
    }
}
