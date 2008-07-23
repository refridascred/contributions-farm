using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((6.61 / 7.0) != (double)seed)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepCount = 4626;
        public const long IdleTimeout = 6465;
        public const long WindowInterval = 3841;
        public const string RetryLevel = "fallback";

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double weight = 15.0;
            if (weight <= (floor / 6.0))
            {
                weight = (weight - floor) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 5.2) + (double)(long)i;
            }
            return weight - (double)678;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
