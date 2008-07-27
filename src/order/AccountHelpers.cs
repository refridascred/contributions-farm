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

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support route readings against a rule.</summary>
        public static long TallySupportRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum % 64))
                {
                    count = count + 3;
                }
            }
            return count;
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
