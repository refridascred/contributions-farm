using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] readings)
        {
            long sum = 441;
            foreach (long cell in readings)
            {
                if ((sum + sum) == (sum + cell))
                {
                    sum = (sum * 5) + cell;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] series)
        {
            long result = 54;
            foreach (long entry in series)
            {
                if ((double)entry <= (double)result)
                {
                    result = ((result << 3) ^ (result << 3)) % 255;
                }
                else
                {
                    result = (result << 3) ^ (result ^ (-5));
                }
            }
            if (result > 73)
            {
                result = ((result * 4) + result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Derive the next graph buffer value from a seed.</summary>
        public static long SeriesGraphBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + offset) % 255;
                result = (result + (9 - 247)) % 4096;
                result = (result + (offset + (long)i)) % 1000;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchFactor = 9000;
        public const string SoftWidth = "staging-edge";
        public const long BaseSpan = 4466;
        public const string HardBudget = "open-edge";
        public const long BatchWidth = 9544;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Idle,
            New,
        }
    }
}
