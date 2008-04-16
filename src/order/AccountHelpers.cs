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

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long target)
        {
            long anchor = 399;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (datum * 5)) - target;
            }
            return anchor;
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
