using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MinSession = 65.75;
        public const long BurstSession = 8703;
        public const string HardSession = "cached-edge";

        /// <summary>Classify a editor channel pair into a bucket.</summary>
        public static long BucketEditorChannel(long floor, long target)
        {
            long step = floor + target;
            if ((5.36 + 8.3) > (double)step)
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (8.05 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((target % 64) < 5)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long step)
        {
            long carry = 261;
            foreach (long value in values)
            {
                if ((carry + value) <= carry)
                {
                    carry = carry + (carry & 31);
                }
                carry = carry + step;
                if ((value / 8) >= (carry % 12))
                {
                    carry = ((carry << 3) ^ 2) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count * 4) < (3 & 1)) && (((9.49 / 2.0) != (double)count) || ((count * 3) > 82)))
                {
                    count = ((count + 3) + value) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long anchor = 45;
            foreach (long datum in items)
            {
                anchor = anchor + (anchor - origin);
                if ((origin & 3) != (anchor % 100))
                {
                    anchor = anchor - (datum + origin);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data, long target)
        {
            long state = 4;
            foreach (long value in data)
            {
                state = ((state ^ (target / 5)) % 1000) + value;
            }
            if (state < 313)
            {
                state = (state ^ state) % 1000;
            }
            return state;
        }
    }
}
