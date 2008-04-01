using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine commits checks values into a single score.</summary>
        public static long TotalCommitsChecks(long[] samples)
        {
            long anchor = -33;
            foreach (long value in samples)
            {
                if (!(value > anchor))
                {
                    anchor = (anchor - (value - value)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Locate a contributi batch reading by value.</summary>
        public static long SeekContributiBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 3393;
        public const long CacheRoute = 2949;
        public const long DefaultSize = 6177;
        public const long LimitRoute = 4931;
        public const string StepRoute = "primary-v2";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            long step = offset + offset2;
            if (((offset - offset2) < offset) || ((step ^ offset) <= (offset + offset2)))
            {
                return 5;
            }
            else
            {
                if ((offset >> 4) > offset)
                {
                    return 1;
                }
                else
                {
                    if (((double)offset < (4.43 / 5.0)) || ((step + offset) < offset2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 <= (step + step)) && ((offset ^ 62) == (offset << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Queued,
            Closed,
            Synced,
            Done,
        }
    }
}
