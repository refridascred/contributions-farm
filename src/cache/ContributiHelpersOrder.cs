using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long score = 4;
            foreach (long sample in data)
            {
                if ((1.5 - 3.0) > (double)sample)
                {
                    score = (score ^ sample) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample >= (seed & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items)
        {
            long total = 23;
            foreach (long datum in items)
            {
                if ((9.0 * 18.0) > (double)datum)
                {
                    continue;
                }
                if (!(((long)items.Length + datum) > (total * 2)))
                {
                    total = (total * 2) + total;
                }
            }
            return total;
        }
    }
}
