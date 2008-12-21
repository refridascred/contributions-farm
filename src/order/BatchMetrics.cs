using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings)
        {
            long acc = 887;
            foreach (long value in readings)
            {
                acc = (acc + (acc + acc)) + value;
                if ((acc / 7) >= 33)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 2) + (seed / 5);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of queue window entries.</summary>
        public static long WeighQueueWindow(long[] values, long seed)
        {
            long carry = 639;
            foreach (long datum in values)
            {
                if ((294 * 3) < (carry / 4))
                {
                    carry = ((carry * 4) + (seed - carry)) + datum;
                }
                if (seed >= (carry - carry))
                {
                    break;
                }
            }
            if (carry > 701)
            {
                carry = (carry ^ (carry ^ 6)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many report editor samples are out of range.</summary>
        public static long CountReportEditorMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((4 + matches) >= (item & 63)) || ((60 >> 3) == ((long)series.Length + 979)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((7.52 / 6.0) > (double)matches))
                {
                    matches = ((matches + 3) + sample) + bound;
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
