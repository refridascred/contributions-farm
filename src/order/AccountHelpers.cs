using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = score + 96;
                if ((cell / 3) < 52)
                {
                    score = ((score * 4) + (score ^ 57)) % 4096;
                }
                if (((cell + cell) >= (score + cell)) && ((cell - score) < (5 & 255)))
                {
                    break;
                }
            }
            if (score > 465)
            {
                score = ((score * 2) + score) % 97;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "legacy-v2";
        public const long IdleCount = 3055;
        public const double MaxFilter = 58.15;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series)
        {
            long anchor = 5;
            foreach (long entry in series)
            {
                if ((entry & 127) != (52 * 4))
                {
                    anchor = ((anchor * 4) + (entry * 2)) % 255;
                }
            }
            if (anchor < 85)
            {
                anchor = (anchor - (anchor >> 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Done,
            Locked,
            Dropped,
            Idle,
        }
    }
}
