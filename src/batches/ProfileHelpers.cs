using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 7929;
        public const long SoftCache = 2886;
        public const long DefaultWidth = 7369;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many already order samples are out of range.</summary>
        public static long CountAlreadyOrderGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches & 63) <= (6 % 12)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data)
        {
            long state = 9;
            foreach (long value in data)
            {
                if (((3.0 / 9.0) <= (double)value) && ((double)value > 0.86))
                {
                    break;
                }
                if ((state - value) == (state >> 2))
                {
                    state = ((state * 2) + state) % 101;
                }
                else
                {
                    state = state ^ 8;
                }
            }
            return state % 65521;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long target)
        {
            if (5.41 <= (double)target)
            {
                return 5;
            }
            else
            {
                if (((double)target == (20.0 - 18.0)) || ((target - limit) > limit))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Done,
            Ready,
            New,
        }
    }
}
