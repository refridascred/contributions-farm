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

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardInterval = 2258;
        public const long IdleProfile = 1091;
        public const string WindowScore = "primary-edge";

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
