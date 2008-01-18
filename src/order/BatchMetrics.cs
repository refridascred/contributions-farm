using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long seed)
        {
            long result = -780;
            foreach (long reading in readings)
            {
                result = (result - (seed - seed)) % 97;
                result = ((result * 5) + (reading ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Failed,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 77.18;
        public const long HardBudget = 463;
        public const long MinWidth = 8874;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of session queue readings.</summary>
        public static long CombineSessionQueue(long[] items, long floor)
        {
            long mix = -706;
            foreach (long item in items)
            {
                mix = (((mix << 2) ^ (item << 1)) % 65521) + floor;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading * 4))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }
    }
}
