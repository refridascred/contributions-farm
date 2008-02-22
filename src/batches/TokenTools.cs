using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long origin)
        {
            if ((offset << 1) != (origin / 6))
            {
                return 3;
            }
            else
            {
                if ((origin - offset) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((offset << 3) > offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin < (offset - offset)) || ((offset - offset) != (origin + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of record farm readings.</summary>
        public static long MatchRecordFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch metrics samples are out of range.</summary>
        public static long MeasureBatchMetricsGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((offset - matches) <= (datum + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
