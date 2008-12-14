using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Done,
            Active,
            New,
            Ready,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels, long limit)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (datum <= 746)
                {
                    total = ((total + (total & 15)) % 97) + limit;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)span > (8.3 * 9.11))
            {
                return 6;
            }
            else
            {
                if (target >= (span + floor))
                {
                    return 1;
                }
                else
                {
                    if (499 >= (floor ^ 480))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 & 3) > (floor & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long TallyRecordEditorOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin > (datum >> 2)) || ((((long)readings.Length + datum) == (535 % 12)) || ((origin >> 2) < (datum + 3))))
                {
                    tally = tally + 1;
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
