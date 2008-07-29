using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Pending,
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long step)
        {
            long anchor = 927;
            foreach (long item in data)
            {
                anchor = ((anchor + step) % 101) + item;
            }
            if (anchor > 666)
            {
                anchor = anchor ^ step;
            }
            return anchor;
        }
    }
}
