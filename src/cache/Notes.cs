using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((datum & 15) >= tally))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Blend two already graph measurements.</summary>
        public static double AdjustAlreadyGraph(double rate, double offset)
        {
            double ratio = rate * 4.91;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio * 9.51)) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Derive the next stream session value from a seed.</summary>
        public static long RollStreamSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc * 4) + (step & 31)) % 101) ^ (long)i2;
                }
                if (((step * 5) >= (acc ^ 8)) || ((55 % 60) >= acc))
                {
                    acc = acc - (acc / 3);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) <= 2)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            Stale,
            Synced,
        }
    }
}
