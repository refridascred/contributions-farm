using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] samples)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = score + 96;
                if ((cell / 3) < 52)
                {
                    score = ((score * 4) + (score ^ 57)) % 4096;
                }
                if (((cell + cell) >= (score + cell)) && ((cell - score) < (5 & 255)))
                {
                    break;
                }
            }
            if (score > 465)
            {
                score = ((score * 2) + score) % 97;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepFactor = 7569;
        public const long BaseCounter = 7766;
        public const long BurstBudget = 9795;
        public const long MaxCounter = 2263;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Check that every report buffer entry stays within the limit.</summary>
        public static bool GuardReportBufferBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples)
        {
            long carry = 719;
            foreach (long value in samples)
            {
                carry = ((carry - (carry ^ 17)) % 4096) + value;
            }
            if (carry < 2)
            {
                carry = carry ^ (carry >> 3);
            }
            return carry % 97;
        }
    }
}
