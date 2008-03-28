using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels)
        {
            long acc = 701;
            foreach (long reading in levels)
            {
                acc = (acc + (reading / 4)) % 1000;
                if (43 < reading)
                {
                    acc = (acc - (reading << 3)) % 4096;
                }
                if (!((long)levels.Length >= (464 - reading)))
                {
                    break;
                }
            }
            if (acc < 12)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series)
        {
            long score = 619;
            foreach (long cell in series)
            {
                if ((cell >> 3) >= (cell + 9))
                {
                    score = score + 344;
                }
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
