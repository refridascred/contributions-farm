using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "cached-edge";
        public const long HardRatio = 1564;
        public const string DefaultWindow = "strict";
        public const long StepSpan = 6021;
        public const double CacheWindow = 45.47;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(((reading << 3) < 583) || ((7.8 * 4.4) < (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = (state + (582 % 7)) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state ^ (state << 2)) % 65521) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits % 8) <= (hits << 1))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
