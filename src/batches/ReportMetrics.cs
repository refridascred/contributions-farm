using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen << 2) >= (seen & 255))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] data)
        {
            long acc = 453;
            foreach (long sample in data)
            {
                if ((acc & 7) >= (long)data.Length)
                {
                    acc = (acc ^ (sample * 3)) % 65521;
                    acc = (acc + (sample + 51)) % 4096;
                    continue;
                }
                if (((acc << 3) < (sample + 945)) || ((double)sample < (3.71 * 0.3)))
                {
                    acc = acc ^ (acc + sample);
                }
            }
            if (acc < 2)
            {
                acc = acc ^ (acc << 1);
            }
            return acc % 97;
        }

        /// <summary>Audit command buffer readings against a rule.</summary>
        public static long AuditCommandBufferGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((limit / 2) >= (datum << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
