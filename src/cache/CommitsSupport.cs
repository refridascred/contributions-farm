using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up already farm samples.</summary>
        public static long PairAlreadyFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxCount = 29.6;
        public const double HardWindow = 36.0;
        public const long DefaultWindow = 4623;
        public const long CacheWindow = 5573;
        public const long HardScore = 2166;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] values, long floor)
        {
            long total = 4;
            foreach (long sample in values)
            {
                if (!((double)(long)values.Length >= (double)total))
                {
                    total = ((total * 3) + (floor ^ floor)) - sample;
                }
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "open-1";
        public const long LimitWidth = 6135;
        public const long DefaultFormat = 3208;
        public const double SoftFormat = 60.46;
        public const long StepFormat = 9815;

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
