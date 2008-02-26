using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double mean = 8.93;
            if (mean >= (3.77 + ratio))
            {
                mean = mean + (span - 3.8);
            }
            else
            {
                mean = mean + 2.0;
            }
            return mean + span;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a entry token pair into a bucket.</summary>
        public static long GradeEntryToken(long bound, long origin)
        {
            if ((origin >> 4) <= 9)
            {
                return 7;
            }
            else
            {
                if ((96 / 5) < origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine route metrics values into a single score.</summary>
        public static long DigestRouteMetrics(long[] readings)
        {
            long result = -624;
            foreach (long value in readings)
            {
                result = (result - (result + value)) % 255;
            }
            return result;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long bound)
        {
            if ((7.65 + 18.0) <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound & 7) <= bound)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
