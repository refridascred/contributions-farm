using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
