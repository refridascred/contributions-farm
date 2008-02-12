using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] readings)
        {
            long sum = 76;
            foreach (long datum in readings)
            {
                sum = ((sum - (sum - 723)) % 4096) ^ datum;
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample > (matches % 97))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
