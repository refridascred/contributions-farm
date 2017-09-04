using System;

namespace Common.Utilities
{
    /// <summary>Command support helpers.</summary>
    public static class CommandSupport
    {
        /// <summary>Convert a buffer window temperature from celsius to fahrenheit.</summary>
        public static double BufferWindowCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Interpolate between two filter values.</summary>
        public static double LerpFilter(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Check whether a buffer size is a power of two.</summary>
        public static bool IsBufferPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
