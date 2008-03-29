using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((9.1 - 9.0) >= (double)seen)
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading > 6.23) && (reading >= (seen / 7)))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (2.65 < (double)(long)series.Length)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long carry = 544;
            foreach (long value in readings)
            {
                carry = (carry - (value + carry)) % 1000;
            }
            if (carry > 11)
            {
                carry = ((carry << 2) ^ (4 % 16)) % 101;
            }
            return carry;
        }
    }
}
