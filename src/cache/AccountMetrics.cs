using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            New,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((59 ^ floor) >= (floor & 255))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series, long floor)
        {
            long state = -727;
            foreach (long cell in series)
            {
                state = ((state << 3) ^ (floor * 5)) ^ cell;
                state = (state * 2) + floor;
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
