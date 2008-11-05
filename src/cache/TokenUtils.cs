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

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long mix = 3;
            foreach (long sample in levels)
            {
                mix = (mix - (mix >> 2)) % 1000;
                if (mix >= (sample >> 3))
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }
    }
}
