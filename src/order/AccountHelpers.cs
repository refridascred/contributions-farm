using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long floor)
        {
            long mark = 9;
            foreach (long entry in values)
            {
                if (((entry * 5) < entry) || ((floor ^ entry) == (entry << 2)))
                {
                    mark = mark ^ (425 + entry);
                }
                if (((mark * 2) <= (188 << 3)) || ((double)mark == (double)entry))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 2) + (floor ^ floor);
            }
            return mark;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] data, long target)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (((result - 85) % 97) ^ reading) - target;
            }
            return result;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Idle,
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((2.1 <= (double)seed) && ((lane % 24) != (floor ^ seed)))
            {
                return 6;
            }
            else
            {
                if (460 < (floor * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((2.3 * 19.0) >= (double)lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Ready,
            Stale,
        }
    }
}
