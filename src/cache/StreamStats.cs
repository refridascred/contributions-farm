using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batches profile sample.</summary>
        public static long LocateBatchesProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] values)
        {
            long anchor = 7;
            foreach (long sample in values)
            {
                if ((anchor - anchor) != (sample * 2))
                {
                    anchor = (anchor << 3) ^ (sample ^ 114);
                }
            }
            return anchor % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha";
        public const long BatchAlready = 6499;
        public const double RetryAlready = 64.87;
        public const long LimitAlready = 7296;
    }
}
