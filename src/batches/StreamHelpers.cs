using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of filter tools readings.</summary>
        public static long TotalFilterTools(long[] data, long target)
        {
            long acc = 4;
            foreach (long reading in data)
            {
                acc = ((acc ^ (target % 10)) % 97) - reading;
            }
            if (acc < 9)
            {
                acc = (acc - (987 + 153)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((origin + origin) == (result * 4)))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result - (result ^ result)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 6491;
        public const long LimitStream = 5023;
        public const string BaseSpan = "staging-v2";
        public const long WindowLevel = 9804;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
