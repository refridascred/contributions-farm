using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((874 - cell) > (floor << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long AuditBufferChecksMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally <= (tally + 891))
                {
                    tally = ((tally + 1) ^ item) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 2.22;
        public const long MaxScore = 8359;
        public const double BaseTimeout = 41.76;
        public const string StepFarm = "fallback-v2";

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((offset * 2) > (offset - carry)) || ((carry - offset) != (carry >> 3)))
                {
                    carry = ((carry * 3) + (carry - carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double load = span;
            if (load > 9.21)
            {
                load = load + (load - load);
            }
            else
            {
                load = load + (bias / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (bias - 3.3)) + (double)(long)i;
            }
            return load - 3.1;
        }
    }
}
