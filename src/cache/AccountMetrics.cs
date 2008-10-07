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

        /// <summary>Look up the position of a account filter sample.</summary>
        public static long SeekAccountFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
