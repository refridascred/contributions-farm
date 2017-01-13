using System;

namespace Common.Utilities
{
    /// <summary>Filter metrics helpers.</summary>
    public static class FilterMetrics
    {
        /// <summary>Calculate a 16-bit checksum of a cluster catalog key.</summary>
        public static int ClusterCatalogChecksum(string text)
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

        /// <summary>Average a list of folder samples.</summary>
        public static double AverageFolder(double[] values)
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
    }
}
