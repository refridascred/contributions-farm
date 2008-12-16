using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Weight { get; set; }
            public long Region { get; set; }
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
