using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Done,
            Ready,
            Paused,
            Active,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data, long seed)
        {
            long mark = 801;
            foreach (long reading in data)
            {
                mark = (mark ^ (seed * 4)) % 255;
                if ((162 / 5) >= seed)
                {
                    mark = (mark << 3) ^ reading;
                }
                if (!(reading < (reading - mark)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
