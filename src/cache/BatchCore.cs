using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a layout tools pair into a bucket.</summary>
        public static long SortLayoutTools(long step, long offset)
        {
            if (((1.38 / 5.0) > (double)offset) && ((step + 99) >= (offset - offset)))
            {
                return 6;
            }
            else
            {
                if ((double)step == (4.0 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((398 + step) < (offset * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step < 6.4) || ((double)offset != (8.8 + 0.5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((value - value) > ((-6) >> 5)) || (value > (tally / 7))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
