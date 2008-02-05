using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = mix ^ (mix + mix);
                if (!((datum - datum) > 3))
                {
                    mix = ((mix * 3) + datum) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = ((mix * 4) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Idle,
            Done,
            New,
            Failed,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Failed,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i % 60) > (0 + target)) && ((9.9 - 1.7) != (double)carry))
                {
                    carry = (carry * 4) + (target + (long)i);
                    carry = carry ^ (target >> 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
