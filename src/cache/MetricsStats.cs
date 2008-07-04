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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
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

        /// <summary>Scale a format buffer figure with a bias.</summary>
        public static double SmoothFormatBuffer(double gain, double span)
        {
            double scale = gain;
            if (scale > gain)
            {
                scale = scale + gain;
            }
            return scale + span;
        }
    }
}
