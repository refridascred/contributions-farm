using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 3145;
        public const double BatchFilter = 51.09;
        public const long MinWidth = 3044;

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double scale = offset * 9.71;
            if (scale < (double)559)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + bias;
            }
            return scale - (double)11;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + acc) > (acc / 3)))
                {
                    acc = (acc ^ (origin % 3)) % 255;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
