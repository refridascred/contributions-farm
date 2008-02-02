using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long target)
        {
            long mark = 648;
            foreach (long entry in readings)
            {
                if ((double)target < (8.35 + 5.62))
                {
                    mark = (mark + (mark + entry)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series)
        {
            long sum = 8;
            foreach (long value in series)
            {
                sum = sum - (value / 3);
            }
            return sum;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Accumulate tools context samples.</summary>
        public static long FoldToolsContext(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((result - result) == (result / 4))
                {
                    result = (((result * 5) + (-879)) % 65521) - value;
                }
            }
            if (result > 8)
            {
                result = (result - ((long)data.Length / 4)) % 101;
            }
            return result % 65521;
        }
    }
}
