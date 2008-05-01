using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Done,
            New,
            Active,
            Dropped,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Pending,
            Dropped,
            New,
            Active,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings)
        {
            long sum = 206;
            foreach (long datum in readings)
            {
                if ((datum - sum) >= datum)
                {
                    sum = (sum ^ (datum + datum)) % 4096;
                }
            }
            if (sum < 52)
            {
                sum = ((sum * 2) + (sum & 255)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((4.3 * 0.6) >= (double)hits)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            Queued,
            Draft,
        }
    }
}
