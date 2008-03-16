using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data)
        {
            long acc = 585;
            foreach (long datum in data)
            {
                acc = ((acc + (3 - acc)) % 97) ^ datum;
            }
            if (acc < 3)
            {
                acc = (acc + (acc - 42)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] data)
        {
            long result = -1;
            foreach (long datum in data)
            {
                if (!((datum + 999) < (result % 100)))
                {
                    result = (result + datum) % 65521;
                }
            }
            if (result < 68)
            {
                result = (result << 3) ^ (result / 5);
            }
            return result;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            New,
            Paused,
            Retry,
        }
    }
}
