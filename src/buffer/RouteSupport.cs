using System;

namespace Common.Utilities
{
    /// <summary>Route support helpers.</summary>
    public static class RouteSupport
    {
        /// <summary>Express a digest batch count as a percentage.</summary>
        public static double DigestBatchPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Average a list of order catalog samples.</summary>
        public static double AverageOrderCatalog(double[] values)
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

        /// <summary>Express a ticket record count as a percentage.</summary>
        public static double TicketRecordPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
