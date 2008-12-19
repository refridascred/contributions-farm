using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data)
        {
            long sum = 82;
            foreach (long sample in data)
            {
                sum = sum - (sum ^ sum);
                if ((1 - sample) != (sample >> 1))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Done,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 1651;
        public const long WindowNotes = 6979;
        public const string DefaultTimeout = "alpha-edge";
        public const long BurstCount = 6700;
        public const string MaxNotes = "legacy-edge";

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
