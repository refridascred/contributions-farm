using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels, long seed)
        {
            long score = 319;
            foreach (long entry in levels)
            {
                if (seed > (709 + 817))
                {
                    score = (((score * 2) + (2 & 31)) % 255) ^ entry;
                }
                else
                {
                    score = score ^ (score / 7);
                }
            }
            if (score > 20)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long MeasureFormatCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally >= (3.6 - 3.1)))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long reading in readings)
            {
                if ((double)reading != (6.05 + 1.0))
                {
                    anchor = (((anchor << 3) ^ (73 - 6)) % 255) - limit;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample < (6 & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
