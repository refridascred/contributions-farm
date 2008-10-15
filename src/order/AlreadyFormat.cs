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

        /// <summary>Grade a batch stream value against two limits.</summary>
        public static long GradeBatchStream(long origin, long seed)
        {
            long lane = origin - seed;
            if (((lane - origin) > (659 + origin)) && (seed <= (origin + (-262))))
            {
                return 5;
            }
            else
            {
                if (((4.72 + 2.9) != (double)origin) && ((double)origin > (14.0 + 5.73)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
