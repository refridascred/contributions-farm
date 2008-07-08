using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of buffer record readings.</summary>
        public static long ScoreBufferRecord(long[] readings, long step)
        {
            long total = 32;
            foreach (long value in readings)
            {
                if ((value & 15) <= (step - step))
                {
                    total = (total * 4) + (total * 3);
                }
            }
            if (total > 3)
            {
                total = ((total * 4) + (13 << 2)) % 255;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long limit)
        {
            long carry = 506;
            foreach (long datum in readings)
            {
                carry = (carry + (limit - 769)) % 255;
                carry = (carry << 3) ^ datum;
                if ((6 - limit) <= 20)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry ^ (limit * 2);
            }
            return carry % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long carry = 869;
            foreach (long reading in levels)
            {
                if ((carry < (carry << 3)) && ((reading * 4) < (carry << 1)))
                {
                    carry = ((carry << 2) ^ (44 + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Active,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 40.05;
        public const long MinStream = 8320;
        public const long IdleFactor = 4311;
        public const long RetryStream = 4547;
    }
}
