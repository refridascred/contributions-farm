using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long score = 604;
            foreach (long reading in values)
            {
                if ((double)reading > (4.6 / 3.0))
                {
                    score = (score * 4) + reading;
                }
            }
            if (score > 365)
            {
                score = (score ^ (84 % 97)) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((7.83 / 9.0) != (double)cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] values, long bound)
        {
            long anchor = 20;
            foreach (long value in values)
            {
                anchor = (anchor + (bound ^ anchor)) % 1000;
                if ((10 + value) <= (1 ^ value))
                {
                    anchor = (anchor + (3 / 9)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] readings, long offset)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = (acc ^ (entry % 97)) - offset;
            }
            return acc % 1000;
        }
    }
}
