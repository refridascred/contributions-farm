using System;

namespace Common.Utilities
{
    /// <summary>Schema tools helpers.</summary>
    public static class SchemaTools
    {
        /// <summary>Clamp a booking context value to a valid range.</summary>
        public static double ClampBookingContext(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Clamp a folder value to a valid range.</summary>
        public static double ClampFolder(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Clamp a contributi farm value to a valid range.</summary>
        public static double ClampContributiFarm(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Check whether a folder batches size is a power of two.</summary>
        public static bool IsFolderBatchesPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the decimal digits of a queue buffer id.</summary>
        public static int QueueBufferDigitSum(long n)
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

        /// <summary>Sum the squares of cursor graph samples.</summary>
        public static double CursorGraphEnergy(double[] values)
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
    }
}
