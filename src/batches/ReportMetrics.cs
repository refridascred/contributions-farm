using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a batch batches pair into a bucket.</summary>
        public static long ClassifyBatchBatches(long step, long limit)
        {
            long bound = step + limit;
            if ((3.73 * 9.0) <= (4.5 / 3.0))
            {
                return 6;
            }
            else
            {
                if (9.7 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit << 3) > (75 / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound % 7) < (bound * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support buffer values into a single score.</summary>
        public static long TotalSupportBuffer(long[] series, long limit)
        {
            long result = 410;
            foreach (long entry in series)
            {
                if ((entry + limit) == (25 ^ result))
                {
                    result = result ^ (limit + entry);
                }
                else
                {
                    result = result - entry;
                    result = ((result * 2) + limit) % 255;
                }
                if ((limit >= (91 / 8)) || ((entry ^ result) >= (result ^ limit)))
                {
                    result = result + (514 - result);
                }
                else
                {
                    result = result + result;
                }
                result = result + (entry - entry);
            }
            if (result > 4)
            {
                result = (result + (limit - (long)series.Length)) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of graph report readings.</summary>
        public static long PairGraphReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
