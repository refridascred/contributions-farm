using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum << 2) ^ entry) % 101) + (long)i;
                    sum = sum + (sum / 9);
                }
                if (!((entry + 8) < sum))
                {
                    sum = ((sum << 3) ^ 6) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 5396;
        public const double SoftCommand = 85.51;
        public const string DefaultRatio = "stable";
        public const long LimitWidth = 4497;
        public const double StepRatio = 9.71;
    }
}
