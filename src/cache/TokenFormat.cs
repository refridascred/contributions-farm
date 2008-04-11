using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a buffer route sample.</summary>
        public static long SeekBufferRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((cell * 4) == (7 >> 2)) || !((47 * 2) == (bound % 24)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = result - (28 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
