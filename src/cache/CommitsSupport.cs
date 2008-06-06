using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long step, long seed)
        {
            long offset = step ^ seed;
            if ((offset <= (offset - 6)) && ((seed + offset) < (step + offset)))
            {
                return 4;
            }
            else
            {
                if (((step / 7) < (step - 64)) && ((offset * 3) > step))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double weight = scale - scale;
            if (weight < 4.3)
            {
                weight = (weight + scale) - offset;
            }
            return weight - (3.53 / 7.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 5986;
        public const long WindowTimeout = 8281;
        public const string SoftQueue = "legacy-v2";

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count % 5) < (count & 15))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools command samples.</summary>
        public static long TotalToolsCommand(long[] data, long seed)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor + anchor) - (long)i) - value;
                }
                anchor = (anchor ^ seed) % 4096;
            }
            if (anchor < 561)
            {
                anchor = (anchor * 5) + (8 + 193);
            }
            return anchor % 97;
        }
    }
}
