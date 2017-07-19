using System;

namespace Common.Utilities
{
    /// <summary>Catalog helpers.</summary>
    public static class Catalog
    {
        /// <summary>Interpolate between two route values.</summary>
        public static double LerpRoute(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Sum the decimal digits of a channel id.</summary>
        public static int ChannelDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Sum the decimal digits of a queue digest id.</summary>
        public static int QueueDigestDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Convert a invoice batches temperature from celsius to fahrenheit.</summary>
        public static double InvoiceBatchesCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Express a payload count as a percentage.</summary>
        public static double PayloadPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
