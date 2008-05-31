using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double load = scale / 8.0;
            if (load > (load + 16.0))
            {
                load = (load + (double)660) - floor;
            }
            else
            {
                load = load + (double)6;
            }
            return load + (scale * 7.0);
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
