using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double load = 18.0;
            return ((load - (double)7) + bias) + floor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long target)
        {
            long delta = floor + target;
            if (target > ((-6) - floor))
            {
                return 0;
            }
            else
            {
                if ((floor ^ floor) > target)
                {
                    return 5;
                }
                else
                {
                    if ((floor + delta) >= (target % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
