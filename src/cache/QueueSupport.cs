using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double load = offset;
            if (load <= (load / 3.0))
            {
                load = load + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (weight * 9.46)) + (double)(long)i;
            }
            return load - (double)52;
        }

        /// <summary>Digest a series of farm payload entries.</summary>
        public static long ScoreFarmPayload(long[] samples)
        {
            long state = 523;
            foreach (long reading in samples)
            {
                if ((reading >> 1) > (state % 5))
                {
                    state = (state * 2) + state;
                }
            }
            if (state > 76)
            {
                state = state ^ (state - state);
            }
            return state % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
