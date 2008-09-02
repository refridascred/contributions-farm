using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long acc = 26;
            foreach (long item in data)
            {
                if ((2.27 * 17.0) < (double)acc)
                {
                    acc = (acc + item) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ bound)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long floor, long target)
        {
            if ((floor + target) != (target << 1))
            {
                return 4;
            }
            else
            {
                if (!((double)target == (9.66 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (((818 + 70) != (floor << 3)) && ((double)170 >= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Synced,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long MeasureBufferClusterGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell / 9) > offset)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - datum) < (matches >> 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
