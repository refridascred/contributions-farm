using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                long prev = (step * 2) >> 4;
                if (8.5 <= (double)result)
                {
                    result = result - 662;
                }
                else
                {
                    result = ((result * 5) + 9) % 97;
                    result = (result * 3) + (prev % 16);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 3) + (60 / 7)) % 97) ^ (long)i2;
                }
                if (!((double)(long)i <= (16.0 * 9.32)))
                {
                    state = (state + state) % 97;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
