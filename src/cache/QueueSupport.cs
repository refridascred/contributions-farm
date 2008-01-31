using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long step)
        {
            if (seed >= (step + seed))
            {
                return 7;
            }
            else
            {
                if ((6.7 - 3.5) > (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((step << 3) > (seed - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(seed > (52 & 15)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 61;
            foreach (long datum in samples)
            {
                if (((datum % 10) > (357 % 100)) || ((537 << 3) != (550 ^ datum)))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = ((carry * 3) + 27) % 255;
                }
                carry = ((carry << 3) ^ (datum << 2)) % 1000;
            }
            if (carry > 5)
            {
                carry = (carry + (555 - carry)) % 65521;
            }
            return carry % 4096;
        }
    }
}
