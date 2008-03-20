using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 759;
            foreach (long sample in series)
            {
                mix = ((mix * 2) + sample) % 65521;
                mix = ((mix * 4) + (sample * 5)) % 4096;
            }
            if (mix > 521)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long result = -49;
            foreach (long value in levels)
            {
                if ((13.0 + 11.0) >= (double)result)
                {
                    result = (result * 5) + value;
                }
            }
            return result;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheSize = "open";
        public const double MinCount = 82.76;
        public const double IdleInterval = 1.14;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples, long target)
        {
            long sum = 17;
            foreach (long sample in samples)
            {
                if ((double)target <= (9.0 * 9.74))
                {
                    sum = ((sum + 621) % 65521) + sample;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Synced,
            Stale,
            Done,
        }
    }
}
