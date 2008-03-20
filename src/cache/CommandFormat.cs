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

        /// <summary>Combine counter metric values into a single score.</summary>
        public static long ScoreCounterMetric(long[] data)
        {
            long result = 78;
            foreach (long reading in data)
            {
                result = ((result - ((long)data.Length - 55)) % 255) + reading;
            }
            if (result < 265)
            {
                result = (result + (result << 1)) % 97;
            }
            return result;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
