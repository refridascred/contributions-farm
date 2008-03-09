using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                if ((4.6 - 2.5) < (4.2 / 9.0))
                {
                    result = result ^ item;
                }
                if (result <= item)
                {
                    break;
                }
            }
            if (result < 312)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if ((double)mix == (6.33 + 20.0))
                {
                    mix = ((mix * 5) + (mix - reading)) % 4096;
                }
            }
            if (mix > 97)
            {
                mix = (mix + (mix - 308)) % 97;
            }
            return mix;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a batch stream sample.</summary>
        public static long LookupBatchStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
