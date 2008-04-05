using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            New,
            Pending,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data, long floor)
        {
            long state = 679;
            foreach (long datum in data)
            {
                if (((double)state > 12.0) || ((datum << 3) <= state))
                {
                    state = ((state << 3) ^ (state - floor)) % 1000;
                }
                else
                {
                    state = (state + (datum + floor)) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit metrics checks readings against a rule.</summary>
        public static long TallyMetricsChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((7.53 + 17.0) == (double)reading)
                {
                    seen = seen + 3;
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
