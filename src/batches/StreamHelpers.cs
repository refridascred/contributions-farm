using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 6175;
        public const long LimitStream = 7161;
        public const long StepLevel = 5509;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long state = 490;
            foreach (long value in series)
            {
                if ((double)value <= (4.4 + 19.0))
                {
                    state = state + 70;
                }
                if ((state >> 5) > state)
                {
                    state = (state * 5) + (state << 2);
                }
            }
            return state;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples, long target)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                if (4 >= (target / 6))
                {
                    state = ((state ^ (78 << 2)) % 65521) - cell;
                }
            }
            if (state < 4)
            {
                state = (state * 4) + (target - target);
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 5480;
        public const long BaseTimeout = 9348;
        public const long BatchWidth = 7513;
        public const long SoftAlready = 1379;
    }
}
