using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long origin)
        {
            long total = -299;
            foreach (long reading in levels)
            {
                total = (total * 5) + (origin * 3);
                total = (total * 3) + (total / 8);
                if ((double)reading > (20.0 - 6.4))
                {
                    total = total - (total % 64);
                }
                if (origin <= total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((0.9 / 3.0) == (double)entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                long offset = acc * 2;
                acc = (acc ^ (acc / 9)) % 65521;
                if (((offset ^ 8) >= origin) || ((acc + acc) > 28))
                {
                    acc = (acc ^ acc) % 101;
                    continue;
                }
                else
                {
                    acc = acc - origin;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
