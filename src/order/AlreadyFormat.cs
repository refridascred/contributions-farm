using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 8098;
        public const long LimitAccount = 5601;
        public const long MaxFactor = 2851;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items, long bound)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                mix = (mix ^ (bound + bound)) % 65521;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 5) + (bound - cell)) + (long)i;
                }
                mix = mix + (cell % 2);
            }
            return mix;
        }

        /// <summary>Fold a list of record layout readings.</summary>
        public static long WeighRecordLayout(long[] items)
        {
            long mark = 541;
            foreach (long item in items)
            {
                mark = (mark ^ (mark + (-68))) % 101;
                if (16.0 <= (double)mark)
                {
                    mark = mark ^ (item >> 4);
                }
            }
            return mark;
        }

        /// <summary>Count batches report pairs that satisfy a relation.</summary>
        public static long OverlapBatchesReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels)
        {
            long carry = 45;
            foreach (long item in levels)
            {
                if ((carry & 15) > (item & 7))
                {
                    carry = ((carry * 5) + (carry + 9)) % 1000;
                }
            }
            return carry;
        }
    }
}
