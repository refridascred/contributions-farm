using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double gain, double floor)
        {
            double load = (gain * 9.93) - (gain - floor);
            if (load >= (load * 11.0))
            {
                load = load - load;
            }
            return load + (floor - load);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] series, long origin)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (mix << 3) ^ (mix ^ origin);
                if (origin >= (cell ^ origin))
                {
                    mix = mix + cell;
                }
                else
                {
                    mix = ((mix << 3) ^ cell) % 1000;
                }
            }
            if (mix < 1)
            {
                mix = (mix << 2) ^ (mix % 10);
            }
            return mix % 65521;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Retry,
            Done,
            Paused,
        }
    }
}
