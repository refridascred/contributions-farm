using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitRatio = 7987;
        public const long StepScore = 4257;
        public const long IdleSchema = 7311;
        public const double StepSchema = 2.54;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length < (9.9 - 2.7))
                {
                    hits = ((hits + 1) + entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((tally % 5) <= (entry + entry)) || ((entry << 2) < tally)) || ((tally / 6) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
