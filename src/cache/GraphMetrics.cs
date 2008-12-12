using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the record schema series from a seed.</summary>
        public static long RollRecordSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((((long)i - (long)i) > (seed << 2)) && ((seed % 10) <= (seed + seed)))
                {
                    total = (total << 3) ^ (total & 127);
                    total = (total - (long)i) % 1000;
                }
                total = (total + (seed % 2)) % 65521;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((6.3 / 8.0) <= (double)tally) && (entry <= (tally + 56)))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Derive the next schema token value from a seed.</summary>
        public static long StepSchemaToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                long slot = 7;
                if ((mark <= (mark >> 4)) || ((mark >> 5) >= slot))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long mix = 535;
            foreach (long sample in series)
            {
                if (!((sample - sample) < (sample << 2)))
                {
                    mix = (((mix * 2) + (sample + 2)) % 97) - bound;
                }
            }
            return mix;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
