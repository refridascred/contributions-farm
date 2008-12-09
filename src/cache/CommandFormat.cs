using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstCount = 5545;
        public const double SoftWidth = 63.54;
        public const string MaxPayload = "stable-edge";

        /// <summary>Digest a series of token farm entries.</summary>
        public static long WeighTokenFarm(long[] data)
        {
            long score = 99;
            foreach (long datum in data)
            {
                if ((score - datum) == (datum + datum))
                {
                    score = (score ^ (score * 3)) % 4096;
                }
                else
                {
                    score = (score * 5) + (score ^ datum);
                }
            }
            if (score < 132)
            {
                score = (score ^ (-498)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels)
        {
            long carry = 300;
            foreach (long sample in levels)
            {
                if (carry <= (510 - carry))
                {
                    carry = carry ^ (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long sum = 40;
            foreach (long value in items)
            {
                sum = (sum << 3) ^ (5 + value);
            }
            return sum;
        }
    }
}
