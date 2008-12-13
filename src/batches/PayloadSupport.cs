using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of order record readings.</summary>
        public static long WeighOrderRecord(long[] readings, long floor)
        {
            long mark = 877;
            foreach (long entry in readings)
            {
                mark = (mark - (mark + entry)) % 255;
                mark = (mark * 4) + (floor / 2);
            }
            return mark % 4096;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
