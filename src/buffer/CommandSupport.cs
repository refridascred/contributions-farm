using System;

namespace Common.Utilities
{
    /// <summary>Command support helpers.</summary>
    public static class CommandSupport
    {
        /// <summary>Wrap a cluster index into a fixed-size ring.</summary>
        public static int WrapClusterIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Convert a command report temperature from celsius to fahrenheit.</summary>
        public static double CommandReportCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Wrap a contributi index into a fixed-size ring.</summary>
        public static int WrapContributiIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
