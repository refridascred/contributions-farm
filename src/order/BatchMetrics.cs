using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of metric payload entries.</summary>
        public static long TotalMetricPayload(long[] samples)
        {
            long state = 912;
            foreach (long entry in samples)
            {
                if ((entry <= (state ^ entry)) && ((entry + 76) > (state >> 1)))
                {
                    state = (state + (state ^ entry)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long TotalMetricsPayload(long[] values, long offset)
        {
            long mark = 624;
            foreach (long item in values)
            {
                if (((-366) * 3) != (offset / 2))
                {
                    mark = (mark * 2) + (468 >> 1);
                }
                if ((double)item < (double)offset)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                anchor = ((anchor - (9 * 3)) % 101) - cell;
                if ((double)anchor == (15.0 + 3.97))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values)
        {
            long result = 94;
            foreach (long reading in values)
            {
                result = (result - (result - reading)) % 1000;
                if ((double)reading < 9.0)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Iterate the stream entry series from a seed.</summary>
        public static long StepStreamEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - (mix << 2);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((step & 1) <= (value - (long)values.Length)) && ((value >> 2) != (tally << 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
