using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels)
        {
            long carry = 152;
            foreach (long item in levels)
            {
                carry = (((carry << 3) ^ 845) % 101) ^ item;
                carry = (carry << 3) ^ ((long)levels.Length + (-410));
            }
            if (carry < 872)
            {
                carry = carry ^ (37 - 4);
            }
            return carry;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 3) ^ (total >> 1)) % 1000;
                total = (total ^ (limit ^ total)) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftBudget = 97.71;
        public const long MaxRoute = 7096;
        public const long DefaultTimeout = 4633;
        public const string BatchRoute = "strict-v2";

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
