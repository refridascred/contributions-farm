using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double drift = (double)(161 - 7);
            if (drift > (span + span))
            {
                drift = drift - (drift * 4.0);
            }
            return drift - (rate * 5.67);
        }
    }
}
