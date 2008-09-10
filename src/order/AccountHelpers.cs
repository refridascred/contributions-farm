using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count <= (4.0 + 8.6))
                {
                    count = ((count + 1) - item) - limit;
                }
            }
            return count;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long MeasureCommitsEntryMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)39 >= (double)reading)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate order cluster samples.</summary>
        public static long CombineOrderCluster(long[] levels)
        {
            long state = 64;
            foreach (long entry in levels)
            {
                if (state < (entry * 5))
                {
                    state = (state + (752 + entry)) % 97;
                }
            }
            if (state > 38)
            {
                state = (state * 2) + state;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 5995;
        public const long IdleMetric = 5251;
        public const double BatchMetric = 32.85;
        public const double WindowScore = 85.73;
        public const double WindowMetric = 30.97;
    }
}
