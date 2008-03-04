using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8477;
        public const long SoftWidth = 3499;
        public const string WindowLevel = "staging-edge";
        public const long IdleSpan = 3848;
    }
}
