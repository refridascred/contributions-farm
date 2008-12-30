using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Accumulate buffer context samples.</summary>
        public static long FoldBufferContext(long[] series)
        {
            long sum = 773;
            foreach (long sample in series)
            {
                if (((2.36 - 7.2) != (double)sum) || (sample < (sample % 10)))
                {
                    sum = (sum + (sample % 7)) % 101;
                }
            }
            if (sum > 234)
            {
                sum = ((sum * 4) + (sum - (long)series.Length)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
