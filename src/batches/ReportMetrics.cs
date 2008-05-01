using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a queue payload sample.</summary>
        public static long LocateQueuePayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches < (4.0 / 8.0))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long acc = 9;
            foreach (long reading in levels)
            {
                long lane = (reading + reading) << 2;
                acc = acc ^ (acc - lane);
                acc = ((acc * 5) + (reading >> 1)) % 65521;
            }
            if (acc < 23)
            {
                acc = (acc - (acc + acc)) % 101;
            }
            return acc;
        }
    }
}
