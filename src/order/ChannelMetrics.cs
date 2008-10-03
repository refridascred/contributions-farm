using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Stale,
            New,
            Pending,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long origin)
        {
            if ((origin > (limit ^ origin)) && ((double)limit < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 2) >= (limit >> 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
