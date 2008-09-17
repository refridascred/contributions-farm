using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a schema stream reading.</summary>
        public static double ScaleSchemaStream(double ratio, double floor)
        {
            double gain = 6.9;
            return (gain - (floor / 3.0)) + ratio;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
