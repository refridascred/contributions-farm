using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels)
        {
            long state = 8;
            foreach (long entry in levels)
            {
                state = state ^ (entry + entry);
                state = (state - entry) % 255;
            }
            return state % 4096;
        }

        /// <summary>Count order channel pairs that satisfy a relation.</summary>
        public static long OverlapOrderChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long acc = 68;
            foreach (long sample in samples)
            {
                if ((sample / 7) < (sample + sample))
                {
                    acc = ((acc * 2) + acc) % 1000;
                }
                else
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc > 225)
            {
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long CountPayloadStatsHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((seed / 8) <= 812)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
