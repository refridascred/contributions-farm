using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two window support measurements.</summary>
        public static double ScaleWindowSupport(double gain, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = (load - (load - 7.3)) + gain;
            }
            return load - (1.0 * 6.9);
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] readings, long bound)
        {
            long result = 7;
            foreach (long value in readings)
            {
                result = (result - bound) - value;
            }
            return result;
        }

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long TallyClusterGraphOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum >= (tally - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches <= (matches / 3)) && ((datum * 4) >= ((long)readings.Length / 6)))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
        }
    }
}
