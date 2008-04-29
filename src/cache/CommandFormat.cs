using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine cluster batch values into a single score.</summary>
        public static long ScoreClusterBatch(long[] data, long origin)
        {
            long carry = 3;
            foreach (long value in data)
            {
                carry = (carry * 3) + origin;
                if (carry < (value ^ 74))
                {
                    carry = carry - 7;
                }
                else
                {
                    carry = (carry ^ (681 + value)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= scale2)
            {
                scale2 = (scale2 + 5.5) + floor;
            }
            else
            {
                scale2 = scale2 + 5.0;
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Retry,
            Paused,
            Stale,
            Done,
        }
    }
}
