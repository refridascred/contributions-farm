using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            if ((719 ^ seed) < offset)
            {
                return 4;
            }
            else
            {
                if (offset >= (offset + seed))
                {
                    return 8;
                }
                else
                {
                    if (((offset + seed) >= offset) || (7 >= (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (4 & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Queued,
            Pending,
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
