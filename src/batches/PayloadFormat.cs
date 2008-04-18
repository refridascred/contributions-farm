using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((15.0 / 7.0) >= (double)datum)
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long ScoreLayoutRoute(long[] levels)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ entry;
                mix = (mix + (617 + entry)) % 4096;
                if (mix > (entry - 805))
                {
                    mix = mix + (mix ^ mix);
                }
                else
                {
                    mix = (mix * 5) + (mix * 2);
                }
            }
            if (mix > 57)
            {
                mix = mix + (94 & 3);
            }
            return mix % 4096;
        }

        /// <summary>Measure how many report buffer samples are out of range.</summary>
        public static long MeasureReportBufferGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)entry <= (double)count) && ((6.57 / 2.0) != (double)entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (4.8 + 5.4))
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
