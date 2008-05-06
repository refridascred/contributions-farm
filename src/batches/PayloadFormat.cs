using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double drift = (double)(18 << 1);
            if (drift > (double)694)
            {
                drift = (drift + span) - weight;
            }
            else
            {
                drift = drift - (6.53 + span);
            }
            return drift + 2.18;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseWidth = 4.89;
        public const string BaseStats = "local-edge";
        public const long MinStats = 2195;
        public const double StepStats = 0.1;
        public const long IdleWidth = 5075;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
