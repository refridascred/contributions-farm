using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks queue values into a single score.</summary>
        public static long CombineChecksQueue(long[] values)
        {
            long state = 9;
            foreach (long cell in values)
            {
                if (!((17.0 + 3.7) > (double)cell))
                {
                    state = state + (cell / 4);
                }
                state = ((state * 5) + cell) % 255;
            }
            if (state < 7)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long sum = 797;
            foreach (long sample in levels)
            {
                if (((long)levels.Length << 2) > ((long)levels.Length >> 4))
                {
                    sum = ((sum << 2) ^ (sum + sample)) % 4096;
                }
                sum = (sum ^ (sum << 3)) % 1000;
            }
            if (sum < 231)
            {
                sum = sum - (sum << 2);
            }
            return sum % 65521;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((8.93 / 4.0) >= (double)floor)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
