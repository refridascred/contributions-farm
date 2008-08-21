using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 22.25;
        public const long LimitWindow = 9543;
        public const long BatchWindow = 9316;
        public const long BatchSize = 9554;
        public const long CacheDepth = 7493;

        /// <summary>Accumulate editor stats samples.</summary>
        public static long TallyEditorStats(long[] values)
        {
            long anchor = 3;
            foreach (long item in values)
            {
                if ((item >= (item % 10)) || (item <= (anchor + anchor)))
                {
                    anchor = (anchor + (anchor >> 4)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ (256 % 3);
                result = ((result << 2) ^ (306 - step)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
