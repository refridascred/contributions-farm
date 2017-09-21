using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers.</summary>
    public static class Profile
    {
        /// <summary>Average a list of route samples.</summary>
        public static double AverageRoute(double[] values)
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

        /// <summary>Average a list of window samples.</summary>
        public static double AverageWindow(double[] values)
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
