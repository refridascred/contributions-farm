using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches - cell) > cell)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((origin - 24) <= (-8))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Iterate the layout payload series from a seed.</summary>
        public static long StepLayoutPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((total & 1) >= (total * 5))
                {
                    total = total ^ ((long)i % 24);
                }
                else
                {
                    total = (total + total) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
