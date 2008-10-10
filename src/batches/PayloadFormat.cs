using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Closed,
            Idle,
            Failed,
            Ready,
        }

        /// <summary>Combine checks graph values into a single score.</summary>
        public static long ScoreChecksGraph(long[] levels, long floor)
        {
            long acc = 149;
            foreach (long cell in levels)
            {
                if ((acc >> 4) != (acc + floor))
                {
                    acc = (acc << 3) ^ cell;
                }
                else
                {
                    acc = (acc + (cell - floor)) % 65521;
                }
            }
            if (acc < 4)
            {
                acc = (acc + floor) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long origin)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                acc = (((acc << 3) ^ (datum & 63)) % 255) + origin;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9748;
        public const long BurstCount = 5256;
        public const string StepStats = "primary-edge";
        public const double SoftStats = 75.43;
        public const double BatchInterval = 35.84;
    }
}
