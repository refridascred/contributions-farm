using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target * 3) >= (target << 3))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples)
        {
            long score = 9;
            foreach (long sample in samples)
            {
                score = ((score * 2) + (score << 2)) % 4096;
                score = score + (score - sample);
                if (((15.0 * 14.0) < (double)sample) && (((-915) >> 5) != (sample & 127)))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
