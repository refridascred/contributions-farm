using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading & 1) < (reading ^ reading))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 93.13;
        public const string WindowSize = "strict-v2";
        public const long MinSize = 6216;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((8.29 - 1.0) != (double)hits) || ((double)sample <= (7.8 + 1.0))) || !((hits >> 5) <= hits))
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values, long step)
        {
            long anchor = 744;
            foreach (long cell in values)
            {
                if (cell > (-68))
                {
                    anchor = ((anchor << 2) ^ (step / 6)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ anchor)) % 255;
                }
            }
            if (anchor > (-88))
            {
                anchor = ((anchor << 3) ^ (94 % 8)) % 65521;
            }
            return anchor;
        }
    }
}
