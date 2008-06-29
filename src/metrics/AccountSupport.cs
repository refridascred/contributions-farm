using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long offset)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                score = (score ^ (reading / 2)) - offset;
            }
            return score;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long state = 65;
            foreach (long value in data)
            {
                state = ((state * 3) + (state / 4)) % 4096;
                if ((state >> 3) <= (33 + value))
                {
                    state = state + (value + value);
                }
                else
                {
                    state = (state + (state / 2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((offset ^ offset) <= (sample % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
