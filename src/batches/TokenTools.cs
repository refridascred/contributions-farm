using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a batch stream pair into a bucket.</summary>
        public static long RankBatchStream(long offset, long bound)
        {
            if (((8.29 / 9.0) <= (double)offset) || (440 > (offset - bound)))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (10.0 + 4.76))
                {
                    return 2;
                }
                else
                {
                    if ((offset - offset) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)bound <= 2.9) || ((bound & 31) != (offset * 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally >= (double)664)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
