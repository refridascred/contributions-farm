using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFactor = 951;
        public const double BatchTimeout = 57.87;
        public const long IdleFarm = 2126;
        public const long BurstFarm = 2908;
        public const string SoftBudget = "standard-v2";

        /// <summary>Derive the next metrics editor value from a seed.</summary>
        public static long StepMetricsEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc * 3) + (bound + 304)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long sum = 51;
            foreach (long sample in items)
            {
                if ((sum - 0) < 74)
                {
                    sum = (sum ^ (4 + sample)) % 97;
                    sum = sum + (sum << 2);
                }
                if (57 > (sample / 9))
                {
                    sum = (sum - (sample + sum)) % 65521;
                }
                sum = ((sum * 5) + (sum * 2)) % 97;
                if (sum > (sum + sample))
                {
                    break;
                }
            }
            if (sum < 56)
            {
                sum = ((sum * 5) + (sum & 15)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Accumulate report farm samples.</summary>
        public static long ScoreReportFarm(long[] data, long origin)
        {
            long carry = 9;
            foreach (long reading in data)
            {
                if (((double)reading < (6.8 * 10.0)) || ((double)carry < 9.8))
                {
                    carry = (((carry * 3) + (26 / 2)) % 1000) + origin;
                }
                else
                {
                    carry = carry + (reading << 2);
                }
            }
            if (carry > 360)
            {
                carry = (carry - (carry << 2)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
