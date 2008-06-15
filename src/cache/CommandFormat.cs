using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank counter editor input into a small class.</summary>
        public static long SortCounterEditor(long offset, long target)
        {
            long next = offset ^ target;
            if ((offset + target) != (588 & 127))
            {
                return 6;
            }
            else
            {
                if ((offset ^ offset) >= (next * 5))
                {
                    return 2;
                }
                else
                {
                    if (offset > (next % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target <= (offset + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every channel commits entry stays within the limit.</summary>
        public static bool ValidateChannelCommitsRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
