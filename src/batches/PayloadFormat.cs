using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((limit & 15) > (limit + limit))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry batches readings.</summary>
        public static long ScoreEntryBatches(long[] values, long origin)
        {
            long mix = 78;
            foreach (long value in values)
            {
                mix = (mix ^ (origin - mix)) + value;
                mix = mix + (85 % 97);
                mix = (mix * 4) + 562;
            }
            if (mix > 422)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally <= (double)limit)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Mode { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
