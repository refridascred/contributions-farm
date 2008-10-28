using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count report contributi pairs that satisfy a relation.</summary>
        public static long OverlapReportContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((floor / 4) < (reading + 6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 91.4;
        public const long MinAccount = 673;
        public const string LimitAccount = "alpha-edge";

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((long)i - 235);
                if (((long)i & 7) < floor)
                {
                    score = (score ^ (score & 15)) % 4096;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
