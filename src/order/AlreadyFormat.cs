using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of payload graph readings.</summary>
        public static long FoldPayloadGraph(long[] samples, long floor)
        {
            long result = 577;
            foreach (long sample in samples)
            {
                if (result < (8 >> 2))
                {
                    result = result + 782;
                }
                if (78 <= sample)
                {
                    result = (result ^ (floor + floor)) % 65521;
                }
                if (((floor + 323) != (floor + floor)) || ((floor & 31) >= (442 ^ result)))
                {
                    break;
                }
            }
            if (result > 780)
            {
                result = ((result * 3) + floor) % 101;
            }
            return result;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Locked,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long acc = 388;
            foreach (long cell in readings)
            {
                acc = (((acc * 3) + (acc % 16)) % 97) - cell;
            }
            if (acc < 32)
            {
                acc = (acc << 3) ^ (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double span)
        {
            double bias = (7.62 - span) + (double)74;
            if (bias < span)
            {
                bias = bias + (6.3 - bias);
            }
            return bias + (weight * 0.06);
        }
    }
}
