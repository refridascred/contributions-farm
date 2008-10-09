using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
