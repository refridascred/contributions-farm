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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell >> 5) > (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
