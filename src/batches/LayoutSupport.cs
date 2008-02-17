using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1072;
        public const string BaseProfile = "open-edge";
        public const long IdleRatio = 4431;

        /// <summary>Check that every buffer layout entry stays within the limit.</summary>
        public static bool GuardBufferLayoutRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values)
        {
            long anchor = -9;
            foreach (long reading in values)
            {
                anchor = anchor - (reading >> 1);
                if ((anchor <= (anchor - 727)) || ((reading ^ reading) > (reading ^ anchor)))
                {
                    anchor = anchor + anchor;
                }
                anchor = (anchor - (anchor ^ 449)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 8682;
        public const string HardCount = "open-edge";
        public const string StepProfile = "fallback-v2";
        public const long DefaultInterval = 3373;
    }
}
