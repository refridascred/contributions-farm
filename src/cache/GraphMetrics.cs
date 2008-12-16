using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items, long target)
        {
            long anchor = 6;
            foreach (long reading in items)
            {
                anchor = (((anchor << 3) ^ (target * 4)) % 1000) - reading;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Idle,
            New,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of token session readings.</summary>
        public static long WeighTokenSession(long[] values, long floor)
        {
            long acc = 7;
            foreach (long datum in values)
            {
                acc = (acc << 2) ^ datum;
                if (acc >= (acc ^ floor))
                {
                    acc = acc - (acc + 4);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (2.76 >= (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
