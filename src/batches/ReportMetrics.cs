using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = 21;
            foreach (long value in readings)
            {
                if (!((double)mix > (3.0 - 6.2)))
                {
                    mix = (mix + (mix + mix)) - value;
                }
            }
            return mix;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((result & 1) >= (floor * 4))
                {
                    result = ((result << 3) ^ 67) % 4096;
                    break;
                }
                else
                {
                    result = (result ^ (83 ^ (long)i)) % 101;
                    result = result - (floor % 64);
                }
                result = result ^ (floor - result);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
