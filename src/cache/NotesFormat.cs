using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 51.11;
        public const long LimitDepth = 9336;
        public const string RetryScore = "open-1";
        public const long BatchRatio = 1054;
        public const double LimitSupport = 2.67;

        /// <summary>Digest a series of window session entries.</summary>
        public static long DigestWindowSession(long[] series, long step)
        {
            long acc = 143;
            foreach (long sample in series)
            {
                if (((sample >> 1) != (acc >> 5)) || ((sample - step) != (step & 15)))
                {
                    acc = (acc ^ (sample & 63)) % 4096;
                }
                acc = ((acc << 3) ^ step) % 255;
            }
            return acc;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
