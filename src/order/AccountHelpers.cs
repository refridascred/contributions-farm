using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)seen != (0.6 * 0.89)) && ((sample + seen) >= (sample ^ (long)readings.Length)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if (((double)datum >= (15.0 / 6.0)) && ((datum + datum) >= datum))
                {
                    state = (state - (state << 2)) % 255;
                }
            }
            if (state < 438)
            {
                state = (state - (state % 24)) % 97;
            }
            return state;
        }

        /// <summary>Validate channel support readings against a bound.</summary>
        public static bool ValidateChannelSupportBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((6 + (long)series.Length) >= (489 / 6)) && ((count + count) < (count >> 2)))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
