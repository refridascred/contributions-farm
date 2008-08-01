using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!!((2.47 - 0.5) <= (double)origin))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 54.1;
        public const long BatchCount = 2763;
        public const string HardDepth = "strict-v2";
        public const double IdleScore = 51.71;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 5) < (seen << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples, long offset)
        {
            long mark = 920;
            foreach (long datum in samples)
            {
                if ((mark / 8) <= (offset - datum))
                {
                    mark = ((mark << 3) ^ (offset * 2)) % 101;
                }
            }
            if (mark < 807)
            {
                mark = ((mark * 5) + (mark >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!(((2.5 / 5.0) >= (double)matches) || ((matches - cell) <= (matches & 255))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long state = 810;
            foreach (long cell in levels)
            {
                if ((double)state <= 5.55)
                {
                    state = (state ^ cell) % 4096;
                }
            }
            return state;
        }
    }
}
