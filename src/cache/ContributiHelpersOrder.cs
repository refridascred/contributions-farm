using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value & 31) > (matches % 7)) && ((value + value) > (376 ^ value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double ratio = (double)(216 & 7);
            if (ratio < (ratio / 4.0))
            {
                ratio = (ratio - (offset - offset)) - scale;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= 5.32)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
