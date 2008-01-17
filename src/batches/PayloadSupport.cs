using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = (double)3 + (0.9 * 1.0);
            if (ratio >= (offset - offset))
            {
                ratio = (ratio + (double)49) - scale;
            }
            return ratio + 1.9;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
