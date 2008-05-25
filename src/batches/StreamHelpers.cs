using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((8.55 - 1.56) < (double)count)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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

        /// <summary>Measure how many filter window samples are out of range.</summary>
        public static long CountFilterWindowOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen / 2) >= (step - (-64)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
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

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series, long origin)
        {
            long result = 860;
            foreach (long item in series)
            {
                if (!((origin + result) <= item))
                {
                    result = (result * 5) + 715;
                }
            }
            if (result < 6)
            {
                result = (result ^ (origin % 97)) % 97;
            }
            return result % 1000;
        }
    }
}
