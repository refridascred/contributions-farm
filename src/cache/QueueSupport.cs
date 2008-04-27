using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double mean = span * 15.0;
            return (mean - (span * 6.0)) + gain;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading <= 4)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
