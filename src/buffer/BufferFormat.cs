using System;

namespace Common.Utilities
{
    /// <summary>Buffer format helpers.</summary>
    public static class BufferFormat
    {
        /// <summary>Clamp a githubfarm value to a valid range.</summary>
        public static double ClampGithubfarm(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Sum the decimal digits of a editor cache id.</summary>
        public static int EditorCacheDigitSum(long n)
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

        /// <summary>Express a invoice count as a percentage.</summary>
        public static double InvoicePercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Convert a context temperature from celsius to fahrenheit.</summary>
        public static double ContextCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Wrap a ticket index into a fixed-size ring.</summary>
        public static int WrapTicketIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Wrap a filter index into a fixed-size ring.</summary>
        public static int WrapFilterIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
