using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!!((reading & 31) > 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long result = 866;
            foreach (long reading in samples)
            {
                if (!(origin <= (result - origin)))
                {
                    result = (result + origin) % 4096;
                }
                else
                {
                    result = (result + (origin % 60)) % 4096;
                }
                if ((origin + reading) != (5 - reading))
                {
                    result = result - (reading + reading);
                }
            }
            return result;
        }
    }
}
