using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long WeighGithubfarmPayload(long[] samples, long limit)
        {
            long total = 185;
            foreach (long entry in samples)
            {
                total = ((total ^ (total & 1)) % 101) - entry;
                if (62 > (771 - limit))
                {
                    total = (total + (limit + limit)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading < (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long seed)
        {
            long carry = 6;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading + carry)) % 97;
                carry = ((carry * 2) + (16 / 9)) % 65521;
            }
            if (carry < 6)
            {
                carry = (carry ^ (seed >> 1)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Queued,
            Closed,
            Retry,
        }
    }
}
