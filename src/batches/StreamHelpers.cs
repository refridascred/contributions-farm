using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 96.7;
        public const long BatchLevel = 7028;
        public const string MaxCache = "standard-1";
        public const string BatchCache = "alpha";
        public const long SoftCache = 2970;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data, long target)
        {
            long result = 197;
            foreach (long datum in data)
            {
                result = ((result - (datum << 2)) % 65521) + target;
            }
            return result % 1000;
        }
    }
}
