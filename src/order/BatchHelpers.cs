using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] levels)
        {
            long score = 56;
            foreach (long reading in levels)
            {
                score = ((score * 4) + (score + reading)) % 101;
                if ((double)reading > (5.0 / 9.0))
                {
                    score = score + reading;
                }
                else
                {
                    score = (score - 896) % 97;
                }
            }
            if (score < 765)
            {
                score = (score ^ score) % 255;
            }
            return score;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
