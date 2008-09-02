using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long TallyAlreadyNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally / 5) < (tally + tally)) || ((datum - 42) <= (datum / 7)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftDepth = 17.75;
        public const double RetryFilter = 29.35;
        public const long SoftFilter = 6834;
        public const double WindowFilter = 4.74;
        public const long StepFilter = 2968;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long origin)
        {
            if ((seed + origin) < seed)
            {
                return 7;
            }
            else
            {
                if (((origin ^ seed) >= (seed + origin)) && ((seed + origin) > (origin + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ 56) != (origin + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed ^ origin) < seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
