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

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 2558;
        public const long SoftTools = 7042;
        public const long DefaultLevel = 2764;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long total = 289;
            foreach (long reading in series)
            {
                total = ((total * 5) + (total >> 3)) % 255;
                if (24 < total)
                {
                    total = (total * 4) + reading;
                }
                total = ((total * 3) + (total & 63)) % 101;
            }
            return total;
        }
    }
}
