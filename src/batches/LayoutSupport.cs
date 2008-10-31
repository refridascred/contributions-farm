using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long bound)
        {
            long mark = 64;
            foreach (long item in data)
            {
                if (((73 % 16) >= bound) || ((mark - 860) <= mark))
                {
                    mark = (mark + (long)data.Length) % 255;
                }
                if (((bound - mark) >= (bound + item)) || ((double)mark != (double)item))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first record tools entry that matches the target.</summary>
        public static long LocateRecordToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long acc = 924;
            foreach (long value in samples)
            {
                if ((value % 3) >= (acc + acc))
                {
                    acc = (acc - (value + value)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + (565 - value)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value + value) > value) && !((value + value) <= (value ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
