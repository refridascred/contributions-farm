using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long PairWindowStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)offset != (3.62 + 2.1))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] samples)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                if ((double)reading < (14.0 / 4.0))
                {
                    total = (total ^ (991 - reading)) % 255;
                }
            }
            return total;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((reading << 1) >= seed) && ((seed + reading) >= seed)) && ((hits - hits) != (177 + seed)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
