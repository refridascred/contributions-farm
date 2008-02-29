using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if ((double)offset >= 4.0)
            {
                return 7;
            }
            else
            {
                if ((double)offset >= 9.55)
                {
                    return 2;
                }
                else
                {
                    if ((offset % 97) != (offset << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
