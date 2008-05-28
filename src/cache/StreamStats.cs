using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph editor readings against a bound.</summary>
        public static bool VerifyGraphEditorLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account batch values into a single score.</summary>
        public static long DigestAccountBatch(long[] samples, long limit)
        {
            long state = 795;
            foreach (long datum in samples)
            {
                state = ((state * 5) + limit) % 4096;
                state = ((state << 2) ^ (datum + datum)) % 1000;
            }
            if (state > 294)
            {
                state = ((state << 3) ^ limit) % 255;
            }
            return state;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
