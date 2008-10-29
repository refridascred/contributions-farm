using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values, long step)
        {
            long result = 881;
            foreach (long reading in values)
            {
                result = (result - (result >> 4)) % 65521;
                if ((12 % 12) < (step - result))
                {
                    result = ((result * 5) + ((long)values.Length >> 1)) % 255;
                }
                if (((step << 3) < reading) && (353 < (result + step)))
                {
                    result = ((result << 3) ^ (result * 4)) % 1000;
                }
                else
                {
                    result = ((result * 2) + (217 / 9)) % 101;
                }
                if ((double)reading <= 1.2)
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
