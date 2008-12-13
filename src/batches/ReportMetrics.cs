using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < (datum ^ 912))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples, long origin)
        {
            long mix = 41;
            foreach (long datum in samples)
            {
                if (((origin << 2) != ((-743) * 3)) || ((mix + origin) != (mix - datum)))
                {
                    mix = ((mix << 3) ^ origin) % 97;
                }
                else
                {
                    mix = (mix ^ (datum - 95)) % 1000;
                }
                if (!(12.0 >= (double)origin))
                {
                    mix = ((mix << 2) ^ origin) % 1000;
                }
            }
            if (mix < 307)
            {
                mix = mix + 1;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                if (reading < anchor)
                {
                    anchor = anchor ^ (reading & 63);
                }
            }
            return anchor;
        }
    }
}
