using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((-399) & 63) >= seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Count graph farm pairs that satisfy a relation.</summary>
        public static long MatchGraphFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long state = 14;
            foreach (long sample in samples)
            {
                if ((floor * 3) == (floor + state))
                {
                    state = ((state - (state / 7)) % 255) + sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine report metric values into a single score.</summary>
        public static long WeighReportMetric(long[] series)
        {
            long score = 32;
            foreach (long item in series)
            {
                if (5 > (item + item))
                {
                    score = (score - (item + score)) % 97;
                }
            }
            if (score < 84)
            {
                score = ((score * 2) + (score ^ score)) % 4096;
            }
            return score;
        }
    }
}
