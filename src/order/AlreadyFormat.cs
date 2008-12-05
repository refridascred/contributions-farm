using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value == (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mix = 15;
            foreach (long item in levels)
            {
                mix = ((mix * 4) + (item + 0)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long offset)
        {
            if ((limit % 2) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset <= (offset & 1)) && ((double)limit < (7.09 + 2.9)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
