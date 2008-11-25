using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((seed + matches) != (matches + 41))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric notes samples.</summary>
        public static long ScoreMetricNotes(long[] levels, long target)
        {
            long result = 205;
            foreach (long datum in levels)
            {
                result = (result ^ 594) % 1000;
                if ((datum >= target) || ((datum ^ target) > datum))
                {
                    result = (result - (datum + result)) % 4096;
                }
                else
                {
                    result = result + (49 & 63);
                }
            }
            if (result > 4)
            {
                result = (result ^ result) % 255;
            }
            return result % 4096;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
