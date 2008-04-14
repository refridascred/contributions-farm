using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            New,
            Ready,
            Idle,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + tally) <= floor)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((step << 1) >= (step2 + 53))
            {
                return 7;
            }
            else
            {
                if ((5.19 / 3.0) > (double)step2)
                {
                    return 8;
                }
                else
                {
                    if ((5.52 / 9.0) == (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
