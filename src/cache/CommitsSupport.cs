using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9107;
        public const long BurstSchema = 8928;
        public const long HardSchema = 6422;
        public const long BatchSchema = 955;

        /// <summary>Measure how many record account samples are out of range.</summary>
        public static long CountRecordAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step <= (count % 16))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings)
        {
            long acc = 1;
            foreach (long datum in readings)
            {
                acc = ((acc ^ 98) % 97) ^ datum;
            }
            if (acc > 4)
            {
                acc = (acc - (703 << 1)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long carry = 980;
            foreach (long item in data)
            {
                carry = carry - (item % 5);
                if ((9 + carry) != (item >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
