using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings, long target)
        {
            long mix = -47;
            foreach (long item in readings)
            {
                if (((item / 6) < (target ^ item)) || ((double)target >= (9.75 * 5.7)))
                {
                    mix = (mix + mix) % 97;
                }
                else
                {
                    mix = mix ^ (mix & 127);
                }
            }
            if (mix > 124)
            {
                mix = (mix * 3) + target;
            }
            return mix % 65521;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (8.3 * 7.24)) + (double)(long)i) - gain;
            }
            return rate + (rate * 15.0);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double bias = (double)(300 + (-52));
            if (bias > 9.3)
            {
                bias = bias - (offset + 5.0);
            }
            else
            {
                bias = bias + (offset * 9.81);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - rate)) + (double)(long)i;
            }
            return bias + (double)0;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
