using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mark = 43;
            foreach (long sample in values)
            {
                mark = (mark << 2) ^ (3 >> 5);
                mark = (mark - (sample ^ 86)) % 4096;
                if (sample >= (sample >> 3))
                {
                    mark = (mark - (sample & 7)) % 97;
                }
                else
                {
                    mark = (mark ^ 3) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Idle,
            Failed,
            Draft,
        }
    }
}
