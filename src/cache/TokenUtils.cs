using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up format notes samples.</summary>
        public static long MatchFormatNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate already editor samples.</summary>
        public static long DigestAlreadyEditor(long[] items, long target)
        {
            long score = 998;
            foreach (long value in items)
            {
                score = ((score << 3) ^ (score & 3)) ^ value;
                if (!((double)score < (2.8 + 1.7)))
                {
                    score = (score * 4) + (target - 19);
                }
            }
            if (score > 5)
            {
                score = ((score << 3) ^ (score % 60)) % 255;
            }
            return score;
        }
    }
}
