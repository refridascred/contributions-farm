using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally != (3.11 / 8.0))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long sum = 90;
            foreach (long sample in series)
            {
                if (sample < (sum + sample))
                {
                    sum = ((sum << 2) ^ (sample * 5)) % 101;
                }
            }
            if (sum < 710)
            {
                sum = (sum * 3) + (sum * 4);
            }
            return sum % 97;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] samples, long origin)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = (((result + result) % 65521) + cell) + origin;
            }
            return result;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Failed,
            Paused,
        }
    }
}
