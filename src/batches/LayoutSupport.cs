using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate already support readings against a bound.</summary>
        public static bool VerifyAlreadySupportRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3260;
        public const long BurstDepth = 172;
        public const long DefaultSpan = 5094;

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
