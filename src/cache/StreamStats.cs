using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a metric checks pair into a bucket.</summary>
        public static long GradeMetricChecks(long limit, long origin)
        {
            if ((origin + (-9)) > origin)
            {
                return 0;
            }
            else
            {
                if ((limit + 80) < (2 % 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin > (6.72 + 3.0)) || (origin <= limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit > origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream record entry stays within the limit.</summary>
        public static bool GuardStreamRecordRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (seed >= (value & 31))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
