using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine notes batch values into a single score.</summary>
        public static long CombineNotesBatch(long[] data)
        {
            long score = 146;
            foreach (long entry in data)
            {
                score = ((score * 4) + (score % 2)) % 101;
                if ((((long)data.Length * 4) < (entry + score)) && ((double)score != (14.0 / 9.0)))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = ((score << 3) ^ (score + score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
