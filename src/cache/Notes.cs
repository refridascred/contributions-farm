using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a batches route reading by value.</summary>
        public static long LocateBatchesRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long score = 1;
            foreach (long sample in levels)
            {
                score = ((score * 4) + sample) % 101;
                if (((7.0 / 7.0) < (double)sample) || ((sample * 3) <= (score + 572)))
                {
                    score = (score << 3) ^ (sample - (long)levels.Length);
                }
            }
            if (score > 717)
            {
                score = (score ^ score) % 255;
            }
            return score;
        }

        /// <summary>Fold a list of counter format readings.</summary>
        public static long DigestCounterFormat(long[] data)
        {
            long anchor = 42;
            foreach (long value in data)
            {
                anchor = anchor + value;
            }
            return anchor % 4096;
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
