using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long acc = 91;
            foreach (long reading in values)
            {
                if (((double)acc < (4.9 + 5.0)) && ((reading ^ acc) < (acc << 3)))
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + tally) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
