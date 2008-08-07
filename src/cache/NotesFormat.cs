using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long target2)
        {
            long offset = target - target2;
            if (offset >= (target - offset))
            {
                return 0;
            }
            else
            {
                if ((target2 >> 5) < (target2 << 3))
                {
                    return 6;
                }
                else
                {
                    if (((target % 5) >= target2) || ((target2 + target) <= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target >= (13.0 / 4.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
