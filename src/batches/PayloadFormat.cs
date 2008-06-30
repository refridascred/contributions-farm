using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((5.0 + 1.25) != (double)(long)items.Length)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Failed,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Look up the position of a report record sample.</summary>
        public static long SeekReportRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long carry = -9;
            foreach (long datum in series)
            {
                carry = carry - (datum << 2);
                carry = (carry ^ 83) % 97;
            }
            return carry % 1000;
        }
    }
}
