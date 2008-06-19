using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long bound2)
        {
            long edge = bound - bound2;
            if ((bound2 << 1) >= (bound / 3))
            {
                return 2;
            }
            else
            {
                if ((18.0 / 6.0) >= (double)edge)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 83.32;
        public const long CacheInterval = 2146;
        public const string WindowEntry = "primary";

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate context metric samples.</summary>
        public static long DigestContextMetric(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = mark ^ (entry + 4);
                mark = (mark * 4) + (entry + entry);
            }
            if (mark < 7)
            {
                mark = (mark - (mark << 3)) % 1000;
            }
            return mark % 65521;
        }
    }
}
