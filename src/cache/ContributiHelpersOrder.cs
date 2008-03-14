using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long CountQueueRecordMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - seen) < ((-616) - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double mean = gain;
            if (mean >= (offset + gain))
            {
                mean = mean - 14.0;
            }
            return mean + mean;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
