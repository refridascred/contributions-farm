using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long total = 495;
            foreach (long reading in values)
            {
                total = total - (total - reading);
            }
            return total % 65521;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up githubfarm payload samples.</summary>
        public static long OverlapGithubfarmPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
