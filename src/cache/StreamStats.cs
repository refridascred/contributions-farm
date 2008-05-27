using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((tally - tally) < (3 - entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of commits schema entries.</summary>
        public static long ScoreCommitsSchema(long[] series, long bound)
        {
            long result = 6;
            foreach (long sample in series)
            {
                if (((double)bound < (1.41 + 8.1)) && ((bound * 2) >= (bound / 2)))
                {
                    result = ((result * 3) + (2 - sample)) % 65521;
                }
            }
            if (result > 17)
            {
                result = (result ^ (long)series.Length) % 97;
            }
            return result;
        }
    }
}
