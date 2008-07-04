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

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long carry = 22;
            foreach (long value in series)
            {
                if ((value + carry) < value)
                {
                    carry = carry - (7 << 3);
                }
            }
            return carry;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long target)
        {
            if ((target >= bound) || ((bound * 2) >= (59 + 458)))
            {
                return 5;
            }
            else
            {
                if (((target * 4) <= (bound + target)) && ((target + target) < target))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
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
