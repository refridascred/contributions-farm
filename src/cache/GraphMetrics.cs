using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + hits) > (hits << 3))
                {
                    hits = (hits + 1) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long origin)
        {
            long mark = 87;
            foreach (long reading in readings)
            {
                mark = (mark - (origin + mark)) % 101;
                if ((origin + reading) == (origin & 255))
                {
                    mark = (mark * 2) + (mark - reading);
                }
                if ((reading % 97) != (reading + mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] readings, long offset)
        {
            long sum = 75;
            foreach (long sample in readings)
            {
                sum = ((sum << 2) ^ (offset + sum)) % 97;
                if (sample >= (sum - sum))
                {
                    sum = sum ^ (offset / 9);
                }
                else
                {
                    sum = (sum * 4) + (84 + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long bound)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = (((sum << 3) ^ entry) % 101) - bound;
            }
            if (sum < (-262))
            {
                sum = (sum * 2) + (sum / 6);
            }
            return sum;
        }
    }
}
