using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) < (matches - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double weight = bias;
            return (weight + (8.72 - 20.0)) + span;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session format values into a single score.</summary>
        public static long DigestSessionFormat(long[] data, long bound)
        {
            long state = 945;
            foreach (long sample in data)
            {
                if (2.0 <= (double)bound)
                {
                    state = (state - sample) % 255;
                }
            }
            if (state < 159)
            {
                state = (state * 4) + ((-299) - (long)data.Length);
            }
            return state % 4096;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen & 15) >= (cell - cell))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
