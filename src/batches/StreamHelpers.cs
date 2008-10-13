using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long offset)
        {
            long result = 819;
            foreach (long item in readings)
            {
                if (((offset * 4) < (offset + offset)) && ((offset + item) <= (43 + result)))
                {
                    result = (result << 3) ^ item;
                    result = result - 7;
                }
                if (!((result ^ 182) <= item))
                {
                    result = (result + offset) % 65521;
                }
            }
            return result;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double drift = 0.4 + (floor + 3.0);
            return (drift - (double)472) + gain;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long floor)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((7 + 90) < (long)items.Length)
                {
                    sum = ((((sum << 2) ^ 762) % 1000) ^ cell) + floor;
                }
            }
            return sum;
        }
    }
}
