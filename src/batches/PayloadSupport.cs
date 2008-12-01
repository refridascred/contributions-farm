using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long floor)
        {
            if ((483 / 6) >= floor)
            {
                return 5;
            }
            else
            {
                if ((step + step) < (step / 4))
                {
                    return 4;
                }
                else
                {
                    if (step > (57 + 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (19.0 - 3.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 3544;
        public const long DefaultToken = 5154;
        public const long RetrySpan = 1089;
        public const long BatchTimeout = 4994;
    }
}
