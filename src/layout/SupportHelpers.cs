using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Check that every entry contributi entry stays within the limit.</summary>
        public static bool ValidateEntryContributiRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every channel support entry stays within the limit.</summary>
        public static bool ValidateChannelSupportRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
