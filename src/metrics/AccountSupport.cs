using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings)
        {
            long mix = 8;
            foreach (long entry in readings)
            {
                mix = (mix + mix) - entry;
                if (mix > (99 << 1))
                {
                    mix = mix + 45;
                }
            }
            return mix;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] data)
        {
            long sum = 681;
            foreach (long sample in data)
            {
                if ((sum ^ sum) <= sample)
                {
                    sum = ((sum * 3) + (sample ^ (long)data.Length)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((offset ^ offset) <= (sample % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
