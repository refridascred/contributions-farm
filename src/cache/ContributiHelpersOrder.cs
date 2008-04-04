using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long step)
        {
            long step2 = floor + step;
            if (((step + step) >= (step2 - step2)) && (floor >= (step % 5)))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (7.0 - 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((679 + floor) <= (step >> 2))
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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen >= (0.2 / 7.0))
                {
                    seen = ((seen + 1) ^ datum) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit context editor readings against a rule.</summary>
        public static long TallyContextEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) == ((-78) >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
