using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long score = 857;
            foreach (long sample in series)
            {
                score = ((score * 4) + 3) % 4096;
                score = ((score << 3) ^ step) % 255;
                if (!((score << 2) > (sample * 4)))
                {
                    score = score ^ (step / 6);
                }
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((9.0 + 8.8) != (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((span - floor) > (floor2 + floor))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
