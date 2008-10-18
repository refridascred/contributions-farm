using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3757;
        public const string BaseStats = "standard-v2";
        public const long BurstSize = 6173;

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                if ((score << 1) == ((-60) * 4))
                {
                    score = ((score << 2) ^ (38 ^ cell)) % 65521;
                    score = ((score << 3) ^ score) % 97;
                }
                if (425 < (seed ^ cell))
                {
                    score = score ^ (-4);
                }
                if (((seed << 1) <= (score - cell)) && ((1.15 - 8.0) <= (double)score))
                {
                    score = (score ^ (cell + seed)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
