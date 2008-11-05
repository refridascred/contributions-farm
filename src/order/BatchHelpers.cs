using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor + (long)i) == (floor - (-45)))
                {
                    acc = acc - floor;
                }
                else
                {
                    acc = ((acc * 3) + acc) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + (result - result)) % 97) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
