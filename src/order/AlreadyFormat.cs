using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 6220;
        public const long WindowSpan = 5978;
        public const double IdleScore = 66.09;
        public const double DefaultDepth = 74.24;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of already checks entries.</summary>
        public static long TallyAlreadyChecks(long[] data)
        {
            long anchor = 73;
            foreach (long reading in data)
            {
                if (anchor > (414 % 10))
                {
                    anchor = (anchor - (reading - anchor)) % 97;
                }
                else
                {
                    anchor = anchor + (reading ^ 23);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 2) < (96 + tally))
                {
                    tally = ((tally + 1) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((243 >> 5) < count)
                {
                    count = ((count + 2) - entry) - seed;
                }
            }
            return count;
        }
    }
}
