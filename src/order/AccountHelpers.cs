using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result & 255);
                if (((offset - (long)i) <= (result ^ offset)) && ((offset + offset) <= 6))
                {
                    result = (result ^ (result % 97)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine support entry values into a single score.</summary>
        public static long DigestSupportEntry(long[] series, long seed)
        {
            long total = 25;
            foreach (long datum in series)
            {
                total = ((((total * 4) + (total - (long)series.Length)) % 255) ^ datum) + seed;
            }
            return total;
        }

        /// <summary>Check that every already queue entry stays within the limit.</summary>
        public static bool VerifyAlreadyQueueLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc ^ (target - 99)) % 101) ^ (long)i2) ^ sample;
                }
                if (target >= acc)
                {
                    acc = (acc ^ (153 << 1)) % 1000;
                }
            }
            if (acc < 839)
            {
                acc = (acc << 2) ^ (acc - 9);
            }
            return acc % 97;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
