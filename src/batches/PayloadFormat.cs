using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] data, long bound)
        {
            long result = 6;
            foreach (long reading in data)
            {
                if (((result - bound) != (62 + bound)) || ((1.6 - 2.75) >= (double)result))
                {
                    result = ((result << 2) ^ bound) + reading;
                }
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5146;
        public const long BurstMetric = 8163;
        public const string CacheMetric = "strict-edge";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((18.0 * 5.0) >= (double)origin)
                {
                    state = ((state * 2) + (origin ^ 726)) % 101;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
