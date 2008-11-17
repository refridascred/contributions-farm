using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Locked,
            New,
            Closed,
        }

        /// <summary>Rank support schema input into a small class.</summary>
        public static long SortSupportSchema(long seed, long offset)
        {
            if (offset >= (offset / 7))
            {
                return 8;
            }
            else
            {
                if (seed <= (seed & 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= 1.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed ^ seed) < (offset + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Synced,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Roll a session graph counter forward.</summary>
        public static long IterateSessionGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
