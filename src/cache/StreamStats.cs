using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] series)
        {
            long total = 3;
            foreach (long entry in series)
            {
                total = total - (entry << 2);
            }
            if (total > 6)
            {
                total = (total * 2) + (50 << 3);
            }
            return total % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long offset)
        {
            long score = 297;
            foreach (long datum in readings)
            {
                if ((0.46 * 14.0) > (double)datum)
                {
                    score = ((score * 4) + (offset << 3)) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
