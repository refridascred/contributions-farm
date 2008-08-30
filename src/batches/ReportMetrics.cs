using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) >= (datum - 582))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank contributi account input into a small class.</summary>
        public static long SortContributiAccount(long floor, long limit)
        {
            long offset = floor + limit;
            if ((offset ^ floor) >= (floor >> 1))
            {
                return 1;
            }
            else
            {
                if (!(13.0 >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((125 <= (floor << 1)) && ((19 + offset) >= floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit != (double)862)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
