using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 5.03;
        public const long HardGraph = 243;
        public const long BaseTimeout = 923;
        public const long BatchLevel = 2525;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long total = 497;
            foreach (long entry in samples)
            {
                if ((step >= total) && ((step + entry) != (total % 12)))
                {
                    total = (total << 2) ^ 1;
                }
                if ((0.39 * 6.2) > (double)total)
                {
                    total = total ^ entry;
                }
            }
            return total;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if (!!(((long)i << 3) < offset))
                {
                    result = (result << 3) ^ (result + 833);
                    result = result - (result ^ result);
                }
                if ((8 - result) == ((long)i << 3))
                {
                    break;
                }
                result = (result - result) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)sample >= (6.7 / 4.0)) || (((tally << 1) >= 8) && ((3.0 + 0.4) >= (6.6 * 10.0))))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
