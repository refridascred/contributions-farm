using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Retry,
            Dropped,
            New,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = result + (71 + result);
                result = (result - (470 + step)) % 101;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long floor)
        {
            if ((double)floor <= 3.59)
            {
                return 1;
            }
            else
            {
                if ((2.28 - 11.0) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (offset <= 7)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((seed + seed) >= seed)
                {
                    break;
                }
                else
                {
                    carry = carry + (seed & 127);
                    carry = carry - (seed - (long)i);
                }
                if ((carry << 2) <= (seed % 60))
                {
                    carry = (carry ^ (82 + 848)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
