using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of payload support entries.</summary>
        public static long FoldPayloadSupport(long[] levels, long origin)
        {
            long score = 129;
            foreach (long datum in levels)
            {
                if ((origin >> 3) != (origin + score))
                {
                    score = (score << 2) ^ (datum - datum);
                }
                else
                {
                    score = ((score * 3) + score) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Combine profile session values into a single score.</summary>
        public static long WeighProfileSession(long[] samples, long bound)
        {
            long result = 6;
            foreach (long cell in samples)
            {
                result = (((result * 4) + (cell * 4)) % 4096) - bound;
            }
            return result;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
