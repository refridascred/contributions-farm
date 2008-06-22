using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long mix = 6;
            foreach (long item in series)
            {
                mix = (((mix << 3) ^ 1) % 255) ^ item;
            }
            return mix;
        }

        /// <summary>Find the first graph checks entry that matches the target.</summary>
        public static long SeekGraphChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account commits series from a seed.</summary>
        public static long StepAccountCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((score / 7) <= score)
                {
                    score = (score ^ ((long)i / 6)) % 255;
                    score = (score - (bound & 1)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally - tally) >= (tally & 127))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
