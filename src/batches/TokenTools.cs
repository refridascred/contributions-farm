using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = state ^ ((long)i * 4);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
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
