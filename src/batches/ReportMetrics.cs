using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item + seen) < (item % 12)) || (((-38) & 7) >= (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long step, long floor)
        {
            long edge = step + floor;
            if (edge < (62 + step))
            {
                return 6;
            }
            else
            {
                if (((479 + 864) <= (69 ^ floor)) || (floor < step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long limit)
        {
            long mark = -822;
            foreach (long reading in readings)
            {
                mark = ((mark - (7 - limit)) % 255) ^ reading;
            }
            return mark % 97;
        }
    }
}
