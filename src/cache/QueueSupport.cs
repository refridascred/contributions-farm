using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Draft,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data, long step)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = ((mix * 4) + (mix - step)) % 97;
                if ((step / 5) <= entry)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Paused,
            Retry,
        }
    }
}
