using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Idle,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long limit)
        {
            long delta = step - limit;
            if ((limit < delta) && ((limit >> 2) <= limit))
            {
                return 5;
            }
            else
            {
                if ((limit >> 1) == (6 + delta))
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= 15.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((delta - 48) != (step - limit)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
