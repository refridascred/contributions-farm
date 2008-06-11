using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up layout record samples.</summary>
        public static long MatchLayoutRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Idle,
            Closed,
            New,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Dropped,
            Retry,
            Pending,
            New,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
