using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long floor, long limit)
        {
            if (((double)402 != (double)floor) && ((limit / 8) != (floor >> 5)))
            {
                return 2;
            }
            else
            {
                if ((double)floor != (2.8 * 16.0))
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit >= (double)3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)limit >= (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every record command entry stays within the limit.</summary>
        public static bool ValidateRecordCommandLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double bias)
        {
            double scale = (double)(2 << 1);
            if (scale <= bias)
            {
                scale = scale - (weight - scale);
            }
            return scale - scale;
        }
    }
}
