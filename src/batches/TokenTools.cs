using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long step2)
        {
            long delta = step + step2;
            if ((step + step) <= (delta * 4))
            {
                return 8;
            }
            else
            {
                if (step2 <= step)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double gain, double offset)
        {
            double scale = 2.9 + (double)5;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - gain;
        }
    }
}
