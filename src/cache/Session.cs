using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values)
        {
            long result = -43;
            foreach (long item in values)
            {
                result = (result * 4) + item;
                result = result + ((long)values.Length & 7);
                if ((result + (long)values.Length) != (result & 63))
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            if (result < 330)
            {
                result = result - (43 - result);
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 50.21;
        public const long StepFilter = 8390;
        public const long IdleFilter = 4941;
        public const double SoftFilter = 38.62;
        public const long DefaultFilter = 7410;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Dropped,
            Done,
            Ready,
            Closed,
        }
    }
}
