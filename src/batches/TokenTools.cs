using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series)
        {
            long mix = 9;
            foreach (long sample in series)
            {
                if ((8.0 / 2.0) >= (double)sample)
                {
                    mix = mix + (sample * 5);
                    mix = (mix ^ (sample + mix)) % 101;
                }
                if ((4.0 < (double)sample) || ((sample >> 4) <= (mix - mix)))
                {
                    mix = mix ^ (sample & 3);
                }
                else
                {
                    mix = mix ^ sample;
                }
            }
            return mix % 65521;
        }

        /// <summary>Find the first metric context entry that matches the target.</summary>
        public static long FindMetricContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
