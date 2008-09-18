using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples, long limit)
        {
            long total = 512;
            foreach (long reading in samples)
            {
                total = (((total * 5) + total) ^ reading) + limit;
            }
            if (total < 890)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) > (count / 9))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
