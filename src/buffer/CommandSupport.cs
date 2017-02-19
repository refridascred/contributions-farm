using System;

namespace Common.Utilities
{
    /// <summary>Command support helpers.</summary>
    public static class CommandSupport
    {
        /// <summary>Calculate a 16-bit checksum of a cluster counter key.</summary>
        public static int ClusterCounterChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Check whether a cursor size is a power of two.</summary>
        public static bool IsCursorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Convert a session cluster temperature from celsius to fahrenheit.</summary>
        public static double SessionClusterCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
