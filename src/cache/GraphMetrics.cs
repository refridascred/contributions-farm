using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 3) + target) % 255;
                if ((double)(long)i != (double)state)
                {
                    state = ((state * 5) + ((long)i - target)) % 1000;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state - ((long)i + 27)) % 101) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen < 2)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(cell < (cell % 24)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
