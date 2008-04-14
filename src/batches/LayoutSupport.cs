using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer commits entry stays within the limit.</summary>
        public static bool VerifyBufferCommitsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long TallyEntryAccountHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((3.0 - 9.0) == (double)entry)
                {
                    count = (count + 3) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
