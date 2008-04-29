using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long offset)
        {
            long edge = bound - offset;
            if ((edge << 1) > 2)
            {
                return 3;
            }
            else
            {
                if ((offset + 3) > edge)
                {
                    return 8;
                }
                else
                {
                    if ((51 + offset) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
