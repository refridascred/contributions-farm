using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            New,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Grade a schema contributi value against two limits.</summary>
        public static long RankSchemaContributi(long bound, long offset)
        {
            long edge = bound + offset;
            if (((bound + edge) >= (offset / 3)) && ((offset - 26) <= (5 * 5)))
            {
                return 0;
            }
            else
            {
                if ((double)edge == (7.0 - 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) >= (offset ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset & 7) <= (edge * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Done,
            Queued,
        }
    }
}
