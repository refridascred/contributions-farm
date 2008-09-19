using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of already profile entries.</summary>
        public static long CombineAlreadyProfile(long[] values, long step)
        {
            long score = 4;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = (((score ^ (cell + cell)) % 4096) - (long)i) + step;
                }
                if ((1.87 / 8.0) == (double)cell)
                {
                    score = score ^ 51;
                }
            }
            if (score > 10)
            {
                score = (score * 2) + (34 * 3);
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstCount = "legacy-v2";
        public const double BatchFarm = 94.35;
        public const string BaseFarm = "cached-1";
        public const string MaxFarm = "stable";
        public const long WindowFarm = 6235;
    }
}
