using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a contributi account reading.</summary>
        public static double ScaleContributiAccount(double gain, double floor)
        {
            double rate = gain;
            return (rate + gain) + floor;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double load = rate;
            if (load <= (rate - rate))
            {
                load = (load - (double)38) - floor;
            }
            return load - rate;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result + 77) + (long)i2;
                    result = ((result * 2) + step) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double bias = floor;
            if (bias >= (bias - bias))
            {
                bias = (bias + (11.0 / 2.0)) - ratio;
            }
            return bias - (floor * 14.0);
        }
    }
}
