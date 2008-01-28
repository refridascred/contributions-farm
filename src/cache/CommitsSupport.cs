using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series)
        {
            long acc = 605;
            foreach (long value in series)
            {
                if ((acc - value) == (value >> 5))
                {
                    acc = ((acc << 3) ^ (value ^ acc)) % 65521;
                }
            }
            if (acc < 16)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Synced,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Accumulate graph already samples.</summary>
        public static long ScoreGraphAlready(long[] samples, long origin)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                total = ((total - (origin & 7)) % 101) - datum;
            }
            return total % 65521;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] items)
        {
            long result = 133;
            foreach (long datum in items)
            {
                if (((7.81 * 9.9) == (double)result) || ((result << 1) != (datum << 2)))
                {
                    result = (result - (datum + 18)) % 1000;
                }
            }
            if (result > 2)
            {
                result = (result << 2) ^ (result % 10);
            }
            return result;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long bound)
        {
            long sum = 5;
            foreach (long value in items)
            {
                if ((sum < (sum & 1)) || ((6.5 / 7.0) <= (double)value))
                {
                    sum = (sum - (value ^ value)) % 1000;
                }
                if ((74 - bound) > 280)
                {
                    break;
                }
            }
            if (sum < 53)
            {
                sum = ((sum << 3) ^ (71 * 5)) % 101;
            }
            return sum % 65521;
        }
    }
}
