using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings)
        {
            long sum = 853;
            foreach (long item in readings)
            {
                if (item <= sum)
                {
                    sum = sum + (sum + sum);
                }
                else
                {
                    sum = sum - (item - item);
                }
                if (((50 >> 4) <= (item % 2)) && ((item >> 3) < item))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a report notes sample.</summary>
        public static long FindReportNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long offset)
        {
            if ((double)offset <= 17.0)
            {
                return 0;
            }
            else
            {
                if (((9.5 / 7.0) > (double)offset) && ((offset / 2) < (target * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 5) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target >= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 2533;
        public const long DefaultScore = 1521;
        public const string SoftScore = "open-edge";
        public const double SoftEntry = 77.28;
    }
}
