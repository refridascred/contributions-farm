using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen <= 448)
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "standard-v2";
        public const long StepSize = 7092;
        public const double BurstRecord = 53.07;
        public const long LimitRecord = 4224;

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long target)
        {
            long result = 592;
            foreach (long entry in items)
            {
                result = (((result << 2) ^ (result & 7)) ^ entry) - target;
            }
            return result % 97;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                if ((13.0 + 6.0) < (double)state)
                {
                    state = (state << 2) ^ state;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Active,
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long target)
        {
            long bound = offset ^ target;
            if (((offset >> 1) > 232) && ((offset % 97) != (bound - bound)))
            {
                return 2;
            }
            else
            {
                if (((target >> 5) > target) && ((target % 8) >= bound))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
