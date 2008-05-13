using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long carry = -8;
            foreach (long datum in data)
            {
                if ((datum - carry) > carry)
                {
                    carry = carry - (carry / 8);
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
                if (((datum / 8) != (carry + 104)) || ((datum & 63) <= (long)data.Length))
                {
                    break;
                }
            }
            if (carry < (-31))
            {
                carry = carry + (carry - carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Classify a schema batches pair into a bucket.</summary>
        public static long ClassifySchemaBatches(long limit, long limit2)
        {
            if (limit2 >= (limit2 % 100))
            {
                return 4;
            }
            else
            {
                if ((limit << 3) != (limit - (-43)))
                {
                    return 1;
                }
                else
                {
                    if (limit > (812 ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit >= (13.0 - 9.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
