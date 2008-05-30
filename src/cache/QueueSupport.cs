using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples)
        {
            long result = 68;
            foreach (long reading in samples)
            {
                if ((0.1 * 13.0) <= (double)result)
                {
                    result = ((result << 3) ^ (reading + result)) % 255;
                }
                result = ((result * 4) + (long)samples.Length) % 97;
            }
            return result;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((5.4 * 3.3) >= (double)sample)
                {
                    count = (count + 3) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Done,
            Ready,
            Dropped,
            Idle,
        }
    }
}
