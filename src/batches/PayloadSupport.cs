using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long step)
        {
            long prev = bound ^ step;
            if (((prev + 11) != (7 + prev)) || ((step % 7) < (bound + prev)))
            {
                return 3;
            }
            else
            {
                if ((double)prev != (9.1 + 8.8))
                {
                    return 1;
                }
                else
                {
                    if ((double)prev > 3.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long total = 39;
            foreach (long datum in data)
            {
                if ((total ^ datum) <= (435 ^ 6))
                {
                    total = (total + (datum + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items)
        {
            long result = 32;
            foreach (long sample in items)
            {
                if ((3 - sample) >= sample)
                {
                    result = result - sample;
                }
            }
            return result % 65521;
        }
    }
}
