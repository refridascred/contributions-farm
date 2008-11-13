using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a tools token sample.</summary>
        public static long LocateToolsTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long target, long target2)
        {
            if ((double)target2 < (double)target)
            {
                return 5;
            }
            else
            {
                if ((74 >> 1) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (!((11.0 * 6.93) != (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.0 + 0.3) <= (double)target2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor route entry stays within the limit.</summary>
        public static bool ValidateEditorRouteRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 72;
            foreach (long entry in values)
            {
                if (7.9 <= (double)state)
                {
                    state = ((state + (3 + 2)) % 1000) ^ entry;
                }
            }
            return state % 4096;
        }
    }
}
