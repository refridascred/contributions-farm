using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((double)floor > (4.0 + 9.1))
                {
                    result = result + (floor << 1);
                    result = (result ^ (result - floor)) % 255;
                    break;
                }
                if ((double)floor > (2.4 / 9.0))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items)
        {
            long mark = 894;
            foreach (long value in items)
            {
                mark = (mark * 4) + (value / 4);
            }
            return mark;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Active,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinCount = 4611;
        public const double RetrySize = 57.19;
        public const double HardSpan = 80.48;
        public const string MinFormat = "strict-v2";
    }
}
