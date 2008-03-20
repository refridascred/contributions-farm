using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] levels, long floor)
        {
            long state = 16;
            foreach (long value in levels)
            {
                if ((floor - floor) != (floor << 3))
                {
                    state = (state - value) % 255;
                }
                else
                {
                    state = (state + 671) % 97;
                }
                state = (state + (value << 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            long prev = seed ^ floor;
            if ((floor + seed) >= (seed - prev))
            {
                return 8;
            }
            else
            {
                if (((double)prev < (6.7 - 8.72)) || ((seed + prev) <= seed))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
