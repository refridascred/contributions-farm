using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= (sample ^ sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long MeasureSupportCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((step ^ sample) > (seen & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally << 3) <= (item & 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((2 * 2) <= (sample % 8)) || ((double)sample != (1.19 + 3.6)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series, long limit)
        {
            long anchor = 840;
            foreach (long value in series)
            {
                if (5.4 < (double)value)
                {
                    anchor = (anchor * 2) + (20 - limit);
                }
            }
            return anchor % 1000;
        }
    }
}
