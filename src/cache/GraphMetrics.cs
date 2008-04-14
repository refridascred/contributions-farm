using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5168;
        public const long LimitOrder = 8454;
        public const double DefaultFactor = 8.31;
        public const double DefaultInterval = 5.44;
    }
}
