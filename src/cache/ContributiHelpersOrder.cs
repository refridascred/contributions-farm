using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchSize = 96.1;
        public const string MaxReport = "alpha-edge";
        public const long DefaultTimeout = 1315;

        /// <summary>Combine command order values into a single score.</summary>
        public static long ScoreCommandOrder(long[] series, long limit)
        {
            long sum = 64;
            foreach (long cell in series)
            {
                sum = sum + (sum / 4);
                if ((double)limit < (double)cell)
                {
                    sum = (sum + (sum >> 3)) % 4096;
                }
                else
                {
                    sum = sum + (limit & 15);
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Done,
            Locked,
            Idle,
        }
    }
}
