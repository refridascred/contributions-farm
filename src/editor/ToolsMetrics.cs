using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long floor)
        {
            long result = 39;
            foreach (long cell in values)
            {
                if (!((5 & 15) != (result ^ 42)))
                {
                    result = result - cell;
                    result = ((result * 5) + (cell + cell)) % 4096;
                }
                if ((159 ^ 28) <= floor)
                {
                    result = (result ^ result) % 4096;
                    result = ((result * 5) + (result - result)) % 4096;
                }
                result = (result * 3) + (result + 59);
                if (!((result + result) > floor))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double ratio = 7.33;
            if (ratio < (ratio / 8.0))
            {
                ratio = (ratio - offset) + weight;
            }
            return ratio + ratio;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph commits input into a small class.</summary>
        public static long BucketGraphCommits(long step, long offset)
        {
            long offset2 = step - offset;
            if (!((offset2 + offset) < step))
            {
                return 5;
            }
            else
            {
                if (offset2 > (step - offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
