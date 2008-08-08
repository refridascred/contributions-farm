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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
