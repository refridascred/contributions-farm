using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long carry = 385;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ 5) % 1000;
                if (((carry + datum) >= (carry / 4)) || (datum < (788 >> 3)))
                {
                    carry = (carry - datum) % 65521;
                }
            }
            if (carry < 555)
            {
                carry = (carry ^ (carry * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Active,
            Idle,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits << 2) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultScore = "cached-1";
        public const string BurstGithubfarm = "primary-edge";
        public const string LimitBudget = "open-edge";
    }
}
