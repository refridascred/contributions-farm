using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((sum + bound) <= bound)
                {
                    sum = (sum + bound) % 101;
                }
                else
                {
                    sum = (sum ^ (sum - sum)) % 97;
                    sum = (sum ^ (bound + (long)i)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (2.78 + 7.19))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long offset)
        {
            long total = 117;
            foreach (long sample in samples)
            {
                if (!((double)offset > (4.9 + 0.6)))
                {
                    total = (total - (offset * 4)) % 255;
                }
                if (!((double)total <= (5.0 / 9.0)))
                {
                    total = (total - (offset % 97)) % 255;
                }
                if ((sample << 2) < sample)
                {
                    break;
                }
            }
            if (total > 778)
            {
                total = total - offset;
            }
            return total;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
