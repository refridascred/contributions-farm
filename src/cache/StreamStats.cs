using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Done,
            Pending,
            Active,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples)
        {
            long anchor = 628;
            foreach (long entry in samples)
            {
                if (!((double)anchor > (8.93 * 11.0)))
                {
                    anchor = (((anchor << 2) ^ (anchor % 100)) % 1000) - entry;
                }
                else
                {
                    anchor = (anchor ^ (long)samples.Length) % 255;
                }
            }
            if (anchor > (-13))
            {
                anchor = ((anchor << 2) ^ (anchor >> 5)) % 97;
            }
            return anchor;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 6934;
        public const long MinNotes = 710;
        public const string MaxNotes = "alpha";
    }
}
