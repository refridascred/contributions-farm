using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinDepth = 2.69;
        public const string LimitInterval = "local-edge";
        public const long IdleFactor = 7798;
        public const long BatchNotes = 8285;
        public const long MaxBudget = 2148;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value % 7) < (matches + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
