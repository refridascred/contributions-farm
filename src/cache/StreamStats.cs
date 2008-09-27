using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - tally) > (reading * 5))
                {
                    tally = (tally + 1) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state + (long)i) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
