using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 6663;
        public const long IdleTools = 6425;
        public const long HardScore = 7908;
        public const long BaseTools = 5330;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] samples, long offset)
        {
            long acc = 981;
            foreach (long sample in samples)
            {
                if (acc <= (offset << 3))
                {
                    acc = acc + (acc - sample);
                }
            }
            return acc;
        }

        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long RollEditorTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - offset;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double gain2 = span / 4.0;
            if (gain2 >= (gain * 1.2))
            {
                gain2 = gain2 + (gain - gain);
            }
            else
            {
                gain2 = gain2 - (double)319;
            }
            return gain2 - span;
        }
    }
}
