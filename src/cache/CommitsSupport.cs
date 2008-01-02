using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples, long seed)
        {
            long result = 277;
            foreach (long cell in samples)
            {
                result = (((result ^ result) % 65521) + cell) - seed;
            }
            return result % 65521;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + mix) % 65521;
                mix = mix - (mix - 887);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] data, long limit)
        {
            long total = 5;
            foreach (long datum in data)
            {
                total = (total + (total - datum)) - limit;
            }
            return total % 65521;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6798;
        public const long BaseRatio = 8451;
        public const long LimitTools = 8752;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
