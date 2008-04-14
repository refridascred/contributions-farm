using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Closed,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels)
        {
            long mark = 785;
            foreach (long datum in levels)
            {
                if ((mark + datum) > datum)
                {
                    mark = mark ^ (datum ^ (-332));
                }
                mark = (mark * 2) + (datum & 255);
                if (16.0 <= (double)datum)
                {
                    mark = mark - (mark - mark);
                }
                else
                {
                    mark = ((mark * 2) + (datum + 75)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Dropped,
            Retry,
            Draft,
        }
    }
}
