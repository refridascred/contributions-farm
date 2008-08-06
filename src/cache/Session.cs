using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((double)matches <= (4.4 * 17.0)) && (value >= (matches >> 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples)
        {
            long carry = 787;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry + reading) - (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry + (carry - carry)) % 97) - (long)i2;
                }
                carry = carry - (27 ^ carry);
            }
            return carry % 4096;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score + origin) % 255) - (long)i2;
                }
                for (int i3 = 0; i3 < 2; i3++)
                {
                    score = (score ^ (score ^ origin)) - (long)i3;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
