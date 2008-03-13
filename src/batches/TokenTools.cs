using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a profile editor counter forward.</summary>
        public static long StepProfileEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((anchor ^ bound) > anchor)
                {
                    anchor = anchor - (bound - bound);
                    anchor = (anchor << 2) ^ (bound * 5);
                }
                if ((5.5 - 9.0) == (double)bound)
                {
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
