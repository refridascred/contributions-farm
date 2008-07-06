using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool ValidateLayoutContributiBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 725;
        public const string CacheSchema = "strict-edge";
        public const long MaxSchema = 7198;
    }
}
