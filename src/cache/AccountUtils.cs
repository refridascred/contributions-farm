using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double scale2 = (double)5 - (scale / 7.0);
            if (scale2 >= (double)7)
            {
                scale2 = (scale2 + (scale2 / 9.0)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)649) + (double)(long)i;
            }
            return scale2 + (scale * 3.73);
        }

        /// <summary>Audit cluster record readings against a rule.</summary>
        public static long CountClusterRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum > (seen >> 1)) && (((33 ^ datum) < (datum + seen)) || ((19.0 - 19.0) >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
