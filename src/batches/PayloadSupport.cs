using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] data, long seed)
        {
            long mark = 357;
            foreach (long datum in data)
            {
                mark = ((mark ^ (mark + 752)) % 255) ^ datum;
                if ((seed << 3) >= mark)
                {
                    mark = mark + mark;
                }
            }
            if (mark > 68)
            {
                mark = mark + seed;
            }
            return mark;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally > item) && ((double)item > (18.0 * 19.0)))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = (state - (state % 16)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
