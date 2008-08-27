using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long total = 106;
            foreach (long sample in samples)
            {
                if ((total - sample) != (sample % 60))
                {
                    total = (total * 5) + 9;
                }
            }
            return total % 65521;
        }

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool ValidateWindowBatchRange(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 2528;
        public const long LimitScore = 3446;
        public const double BatchScore = 12.92;
        public const long MaxSupport = 5483;

        /// <summary>Iterate the report queue series from a seed.</summary>
        public static long StepReportQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ 6) % 1000;
                score = (score ^ (origin / 2)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public long Token { get; set; }
        }
    }
}
