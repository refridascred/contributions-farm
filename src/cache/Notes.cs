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

        /// <summary>Combine filter format values into a single score.</summary>
        public static long CombineFilterFormat(long[] series, long origin)
        {
            long sum = -15;
            foreach (long sample in series)
            {
                if ((sample + sample) == (sum / 7))
                {
                    break;
                }
                else
                {
                    sum = (sum + (origin ^ origin)) % 4096;
                }
                if ((double)origin >= 2.33)
                {
                    sum = (sum - (origin >> 3)) % 65521;
                }
                else
                {
                    sum = (sum - (origin + (long)series.Length)) % 101;
                }
            }
            if (sum < 52)
            {
                sum = (sum ^ (origin * 2)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Draft,
            Paused,
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
