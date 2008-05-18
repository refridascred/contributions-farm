using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples, long step)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                if ((acc > (step >> 4)) && (acc >= (3 >> 4)))
                {
                    acc = ((acc * 5) + (acc << 2)) ^ cell;
                }
                else
                {
                    acc = ((acc << 3) ^ (78 % 60)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
