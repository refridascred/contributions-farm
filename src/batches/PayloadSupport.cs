using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of order channel readings.</summary>
        public static long CombineOrderChannel(long[] data)
        {
            long total = 911;
            foreach (long reading in data)
            {
                total = total + total;
                if ((reading - total) != (9 & 255))
                {
                    total = (total + (reading << 2)) % 255;
                }
            }
            return total;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long origin, long step)
        {
            long span = origin + step;
            if ((span << 3) <= step)
            {
                return 1;
            }
            else
            {
                if (((-7) > span) || ((origin & 7) != (span - span)))
                {
                    return 8;
                }
                else
                {
                    if ((span % 3) > (91 + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >> 3) >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
