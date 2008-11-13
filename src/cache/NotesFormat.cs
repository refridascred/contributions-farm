using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine buffer token values into a single score.</summary>
        public static long FoldBufferToken(long[] data)
        {
            long score = 239;
            foreach (long value in data)
            {
                if ((9.0 / 2.0) > (double)score)
                {
                    score = (score ^ (score >> 3)) + value;
                }
            }
            if (score > 685)
            {
                score = ((score << 3) ^ (score - score)) % 1000;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "alpha-edge";
        public const long BaseEditor = 7690;
        public const long LimitEditor = 7142;
        public const long DefaultLevel = 6864;
        public const string BaseScore = "legacy";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
