using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double bias, double offset)
        {
            double bias2 = offset;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + 16.0) + (double)(long)i) - bias;
            }
            return bias2 + offset;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long seed, long target)
        {
            if ((seed % 8) < target)
            {
                return 8;
            }
            else
            {
                if (seed < target)
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) == (46 - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((6.3 - 20.0) > (double)seed) || ((seed - 9) == (target + target)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
