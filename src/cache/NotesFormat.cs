using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items)
        {
            long score = -8;
            foreach (long value in items)
            {
                if (((long)items.Length & 127) != (score + score))
                {
                    score = ((score * 4) + (value + value)) % 255;
                }
            }
            if (score < 635)
            {
                score = ((score << 3) ^ (score * 4)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheLevel = 5145;
        public const long HardLevel = 3091;
        public const double WindowSchema = 21.62;
    }
}
