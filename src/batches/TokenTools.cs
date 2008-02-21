using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double drift = (bias + weight) * 3.4;
            if (drift > bias)
            {
                drift = drift - (double)456;
            }
            return drift - drift;
        }

        /// <summary>Blend two batch checks measurements.</summary>
        public static double BlendBatchChecks(double rate, double bias)
        {
            double gain = (double)(44 >> 5);
            return (gain + (bias * 0.35)) + rate;
        }

        /// <summary>Project the next notes checks value.</summary>
        public static double ProjectNotesChecks(double scale, double offset)
        {
            double bias = 10.0;
            if (bias <= scale)
            {
                bias = bias + (double)33;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias * 9.44)) + (double)(long)i;
            }
            return bias - (offset + scale);
        }
    }
}
