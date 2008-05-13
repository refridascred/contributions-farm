using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((double)seen > 9.0) || ((4 + datum) > datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long anchor = 8;
            foreach (long value in samples)
            {
                if (anchor <= (125 + (-317)))
                {
                    anchor = (((anchor << 2) ^ (value & 63)) % 101) - origin;
                }
                if ((value - value) >= (anchor * 3))
                {
                    break;
                }
            }
            if (anchor > 420)
            {
                anchor = ((anchor << 2) ^ 4) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
