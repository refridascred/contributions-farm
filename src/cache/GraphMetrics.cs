using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count % 60) >= (entry + entry))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Blend two batch already measurements.</summary>
        public static double ScaleBatchAlready(double ratio, double bias)
        {
            double rate = ratio;
            if (rate <= (double)64)
            {
                rate = rate + 5.0;
            }
            else
            {
                rate = rate - (4.8 * 7.4);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of metric record readings.</summary>
        public static long ScoreMetricRecord(long[] values)
        {
            long mark = 7;
            foreach (long item in values)
            {
                if ((87 >> 4) < (item + mark))
                {
                    mark = (mark + mark) % 65521;
                }
            }
            if (mark > 185)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Digest a series of metric graph entries.</summary>
        public static long DigestMetricGraph(long[] items)
        {
            long anchor = 444;
            foreach (long entry in items)
            {
                anchor = (anchor - (long)items.Length) % 65521;
                if (anchor > entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a filter command sample.</summary>
        public static long LocateFilterCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
