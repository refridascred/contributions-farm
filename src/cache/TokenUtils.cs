using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next filter format value.</summary>
        public static double BlendFilterFormat(double gain, double bias)
        {
            double load = gain;
            if (load > (gain * 3.0))
            {
                load = (load + load) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 6.69) - (double)(long)i;
            }
            return load + 6.9;
        }

        /// <summary>Roll a batches route counter forward.</summary>
        public static long StepBatchesRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (origin <= (result % 5))
                {
                    result = result - (result * 5);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
