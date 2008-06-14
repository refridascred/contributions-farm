using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the schema report entries that pass the check.</summary>
        public static long AuditSchemaReportHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((9.0 / 6.0) == (double)reading)
                {
                    seen = (seen + 1) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items, long bound)
        {
            long state = 5;
            foreach (long datum in items)
            {
                if ((double)bound > 3.02)
                {
                    state = (state + (bound + datum)) % 65521;
                }
            }
            if (state < 987)
            {
                state = (state * 4) + (0 / 8);
            }
            return state % 65521;
        }
    }
}
