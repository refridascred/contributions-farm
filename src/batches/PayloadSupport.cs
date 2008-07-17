using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batches entry readings.</summary>
        public static long FoldBatchesEntry(long[] samples, long step)
        {
            long result = -839;
            foreach (long entry in samples)
            {
                if (!!((9.2 + 0.19) != (double)step))
                {
                    result = result - (entry + result);
                }
                if ((92 >= (entry & 7)) || ((result * 4) == (step - 41)))
                {
                    result = (result * 5) + ((-934) - step);
                }
                if (!((result % 3) < entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Locked,
            Ready,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
