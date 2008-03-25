using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if ((543 - step) <= (61 + result))
                {
                    result = result - (step + 633);
                    break;
                }
                result = (result - result) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
