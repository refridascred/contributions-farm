using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = 548;
            foreach (long datum in readings)
            {
                mark = (mark * 4) + (datum + 802);
                if ((mark < (datum / 9)) && ((double)mark > (7.8 * 5.43)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit tools checks readings against a rule.</summary>
        public static long CountToolsChecksOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + matches) < (sample >> 2))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((404 % 97) < seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
