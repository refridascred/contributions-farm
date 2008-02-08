using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data, long origin)
        {
            long score = 5;
            foreach (long sample in data)
            {
                if ((origin >> 2) >= ((-2) + sample))
                {
                    score = (score + (547 >> 4)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long mark = 65;
            foreach (long value in series)
            {
                if ((522 + 51) >= (value % 64))
                {
                    mark = (mark - value) % 1000;
                }
                else
                {
                    mark = ((mark * 4) + (value & 63)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Pending,
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Audit report batch readings against a rule.</summary>
        public static long TallyReportBatchMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (4.0 > (double)datum)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
