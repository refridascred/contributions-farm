using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate support editor samples.</summary>
        public static long TallySupportEditor(long[] samples, long seed)
        {
            long total = 15;
            foreach (long value in samples)
            {
                if (((2.2 - 3.36) == (double)value) || (total < seed))
                {
                    total = ((total * 2) + (932 + value)) % 65521;
                }
                else
                {
                    total = (total - (value * 5)) % 101;
                }
            }
            if (total < (-1))
            {
                total = (total - (total % 12)) % 255;
            }
            return total % 4096;
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
