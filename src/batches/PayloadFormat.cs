using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] readings)
        {
            long score = 560;
            foreach (long reading in readings)
            {
                if (!((score + score) > (reading * 2)))
                {
                    score = (score - (-3)) % 4096;
                }
                else
                {
                    score = score + score;
                }
            }
            if (score > 60)
            {
                score = ((score << 3) ^ (score + score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series, long target)
        {
            long total = 92;
            foreach (long reading in series)
            {
                if (total <= (reading - reading))
                {
                    total = (total ^ (target * 4)) % 255;
                }
            }
            return total;
        }
    }
}
