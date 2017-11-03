using System;

namespace Common.Utilities
{
    /// <summary>Payload tools helpers.</summary>
    public static class PayloadTools
    {
        /// <summary>Express a command stream count as a percentage.</summary>
        public static double CommandStreamPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Average a list of batches samples.</summary>
        public static double AverageBatches(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Calculate a 16-bit checksum of a cache key.</summary>
        public static int CacheChecksum(string text)
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

        /// <summary>Sum the squares of cache samples.</summary>
        public static double CacheEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Calculate a 16-bit checksum of a context queue key.</summary>
        public static int ContextQueueChecksum(string text)
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

        /// <summary>Convert a catalog temperature from celsius to fahrenheit.</summary>
        public static double CatalogCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
