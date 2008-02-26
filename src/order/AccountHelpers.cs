using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count editor support pairs that satisfy a relation.</summary>
        public static long PairEditorSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Idle,
            Active,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((double)seen == (4.2 * 2.8)) && ((reading > (seen << 2)) || ((bound ^ reading) <= (811 ^ 56))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ offset) < (entry - entry)) || ((seen - seen) >= (seen >> 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
