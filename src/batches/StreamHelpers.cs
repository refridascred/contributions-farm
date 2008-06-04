using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every entry support entry stays within the limit.</summary>
        public static bool GuardEntrySupportBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter entry samples.</summary>
        public static long DigestFilterEntry(long[] items, long limit)
        {
            long anchor = 319;
            foreach (long cell in items)
            {
                if (!((cell % 16) > 980))
                {
                    anchor = (anchor - 296) - limit;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 4) + 951) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 90.12;
        public const long DefaultAccount = 339;
        public const long MinAccount = 8725;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Ready,
            Closed,
            Draft,
        }
    }
}
