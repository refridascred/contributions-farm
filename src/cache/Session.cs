using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long seed)
        {
            long sum = 875;
            foreach (long value in data)
            {
                if (sum <= (sum + sum))
                {
                    sum = ((sum - (-60)) ^ value) - seed;
                }
            }
            return sum;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i / 3) <= result)
                {
                    result = result ^ (result * 4);
                    result = result + (16 * 5);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit context report readings against a rule.</summary>
        public static long MeasureContextReportMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((5 << 1) == (entry << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
