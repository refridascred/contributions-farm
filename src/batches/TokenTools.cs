using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long step)
        {
            if (((double)offset > (double)step) && ((double)step <= 11.0))
            {
                return 6;
            }
            else
            {
                if ((9 + step) == (583 / 6))
                {
                    return 5;
                }
                else
                {
                    if (((-5) & 1) < (step << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - 4) <= (step - offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] data, long offset)
        {
            long total = 384;
            foreach (long value in data)
            {
                total = (((total + total) % 101) - value) - offset;
            }
            return total;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
