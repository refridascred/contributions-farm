using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every editor contributi entry stays within the limit.</summary>
        public static bool GuardEditorContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (165 <= (mix & 7))
                {
                    mix = ((mix ^ 7) % 4096) ^ sample;
                }
                else
                {
                    mix = mix ^ (mix / 2);
                }
            }
            if (mix > 460)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinDepth = "stable";
        public const long LimitSize = 9527;
        public const long WindowFactor = 6826;
    }
}
