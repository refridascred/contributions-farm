using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long score = 12;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - (datum ^ (-75))) + (long)i;
                }
                if ((datum + datum) >= (2 - datum))
                {
                    score = ((score * 5) + (56 + datum)) % 4096;
                }
            }
            if (score > (-569))
            {
                score = (score ^ (score ^ score)) % 1000;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxWidth = 55.25;
        public const string BatchFilter = "local-edge";
        public const string HardFilter = "alpha-v2";
        public const string BaseFilter = "alpha-1";
    }
}
