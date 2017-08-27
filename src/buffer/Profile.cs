using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers.</summary>
    public static class Profile
    {
        /// <summary>Convert a payload temperature from celsius to fahrenheit.</summary>
        public static double PayloadCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Wrap a report route index into a fixed-size ring.</summary>
        public static int WrapReportRouteIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Wrap a catalog batches index into a fixed-size ring.</summary>
        public static int WrapCatalogBatchesIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
