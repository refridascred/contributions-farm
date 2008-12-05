using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long MeasureBatchEditorGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) <= (floor * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (28 < (entry + floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long origin)
        {
            if ((16.0 - 5.23) > (double)origin)
            {
                return 5;
            }
            else
            {
                if ((origin / 4) >= (bound + origin))
                {
                    return 4;
                }
                else
                {
                    if (!(origin >= (bound ^ 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((6.8 - 4.4) != (double)matches)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
