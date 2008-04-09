using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (2.0 / 2.0))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Closed,
            New,
            Synced,
            Locked,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Locked,
            Stale,
            Pending,
            Idle,
        }
    }
}
