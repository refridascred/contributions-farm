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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinFactor = 43.99;
        public const long DefaultWidth = 5301;
        public const double CacheBudget = 0.69;
        public const long WindowStream = 9015;

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
