using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches < (3.79 / 6.0))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long bound)
        {
            if (!((bound / 2) > (bound / 7)))
            {
                return 0;
            }
            else
            {
                if (!((double)floor < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (!((5.7 - 8.15) <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Locked,
            Ready,
        }
    }
}
