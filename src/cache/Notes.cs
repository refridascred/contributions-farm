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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if ((7.0 - 5.86) == (double)target)
                {
                    acc = ((acc << 2) ^ ((long)i + target)) % 97;
                    acc = acc + (6 - acc);
                    continue;
                }
                acc = (acc + ((long)i << 3)) % 97;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long sum = -212;
            foreach (long value in readings)
            {
                if ((bound % 64) < 9)
                {
                    sum = (sum + sum) - value;
                }
            }
            if (sum < 650)
            {
                sum = (sum + 0) % 97;
            }
            return sum % 97;
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
