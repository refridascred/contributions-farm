using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine filter batch values into a single score.</summary>
        public static long TotalFilterBatch(long[] readings)
        {
            long sum = 343;
            foreach (long cell in readings)
            {
                if ((cell - 8) != (sum % 24))
                {
                    sum = sum + (sum << 1);
                }
                else
                {
                    sum = (sum * 3) + (3 / 7);
                }
            }
            return sum;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (floor / 9)) % 65521;
                if ((double)floor <= 6.1)
                {
                    result = (result * 4) + ((long)i % 60);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long CombineNotesMetric(long[] levels, long bound)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if (bound < (sum + bound))
                {
                    sum = sum - (sample - sum);
                    break;
                }
                if ((double)sample == (8.1 + 3.29))
                {
                    sum = (sum * 4) + (bound << 1);
                }
            }
            return sum;
        }
    }
}
