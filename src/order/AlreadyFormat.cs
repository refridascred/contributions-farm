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

        /// <summary>Compare every pair of checks graph readings.</summary>
        public static long CompareChecksGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public double Stamp { get; set; }
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
