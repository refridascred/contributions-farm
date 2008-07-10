using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool CheckWindowChannelBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate route context samples.</summary>
        public static long CombineRouteContext(long[] items)
        {
            long mark = 828;
            foreach (long sample in items)
            {
                mark = (mark << 2) ^ (sample + mark);
            }
            if (mark < 912)
            {
                mark = (mark * 3) + 2;
            }
            return mark % 65521;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
