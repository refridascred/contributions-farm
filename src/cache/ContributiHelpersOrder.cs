using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank schema graph input into a small class.</summary>
        public static long RankSchemaGraph(long step, long seed)
        {
            long offset = step - seed;
            if ((seed ^ seed) < (seed + 416))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (3.8 + 19.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset + seed) >= (offset - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 8163;
        public const long BurstProfile = 618;
        public const long StepProfile = 4691;
        public const long DefaultInterval = 5365;
    }
}
