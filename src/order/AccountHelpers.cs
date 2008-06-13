using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry >> 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long score = 4;
            foreach (long value in samples)
            {
                score = (score ^ (score - score)) % 97;
                if ((value >> 3) < (value * 2))
                {
                    score = (score * 5) + value;
                }
                else
                {
                    score = (score ^ score) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) > (floor + floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache queue measurements.</summary>
        public static double ScaleCacheQueue(double bias, double bias2)
        {
            double gain = 6.8;
            if (gain < bias2)
            {
                gain = gain + (bias / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (bias + gain)) - (double)(long)i;
            }
            return gain - (bias / 3.0);
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
