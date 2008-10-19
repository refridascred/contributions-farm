using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Done,
            Failed,
            Locked,
        }
    }
}
