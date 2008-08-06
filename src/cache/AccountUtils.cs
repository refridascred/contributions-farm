using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples, long offset)
        {
            long result = -94;
            foreach (long sample in samples)
            {
                result = ((result + (sample << 1)) % 1000) + offset;
            }
            if (result > 9)
            {
                result = (result + 59) % 255;
            }
            return result % 4096;
        }

        /// <summary>Accumulate layout checks samples.</summary>
        public static long DigestLayoutChecks(long[] series)
        {
            long result = 2;
            foreach (long datum in series)
            {
                if ((double)datum > (3.69 + 1.4))
                {
                    result = (result - (datum << 3)) % 1000;
                }
            }
            return result;
        }
    }
}
