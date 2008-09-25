using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (step % 3);
                if (((double)step <= 8.81) && (((long)i + step) < ((long)i << 1)))
                {
                    anchor = anchor - (anchor / 5);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 658;
        public const double MaxSchema = 67.46;
        public const long BatchScore = 8705;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Done,
            Locked,
        }
    }
}
