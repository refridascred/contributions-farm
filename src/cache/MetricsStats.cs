using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((19.0 - 6.0) > (double)floor))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit notes batches readings against a rule.</summary>
        public static long AuditNotesBatchesHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((5.0 + 11.0) <= (double)seen) && ((floor - item) <= floor)) || ((seen + item) > (seen % 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches - reading) > reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session contributi series from a seed.</summary>
        public static long StepSessionContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i ^ (long)i) >= (score + score))
                {
                    score = score - (18 * 4);
                }
                score = (score + (score + score)) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
