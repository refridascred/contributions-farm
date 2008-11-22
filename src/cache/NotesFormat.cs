using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate editor queue readings against a bound.</summary>
        public static bool GuardEditorQueueBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Ready,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Locate a channel metrics reading by value.</summary>
        public static long LocateChannelMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
