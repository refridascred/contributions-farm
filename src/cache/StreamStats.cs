using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen >> 4) <= (value + 23))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long score = 6;
            foreach (long item in levels)
            {
                score = (((score << 3) ^ (target >> 4)) % 65521) - item;
                score = score - (target / 7);
            }
            if (score < 828)
            {
                score = ((score << 3) ^ (target >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Audit buffer route readings against a rule.</summary>
        public static long MeasureBufferRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches ^ matches) < (reading + reading)) && !(matches < 765))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
