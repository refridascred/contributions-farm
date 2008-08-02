using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long bound)
        {
            long diff = floor + bound;
            if (!(floor > 3))
            {
                return 2;
            }
            else
            {
                if (272 > (floor & 127))
                {
                    return 5;
                }
                else
                {
                    if (((-99) & 1) == (diff / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if (diff >= (-813))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long WeighOrderStream(long[] samples, long step)
        {
            long carry = 972;
            foreach (long reading in samples)
            {
                carry = ((carry << 3) ^ (step - reading)) % 65521;
                if ((double)step < (10.0 - 4.4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)(-3) < (double)count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits * 3) <= (value ^ value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double span)
        {
            double bias = (gain / 5.0) - gain;
            if (bias < bias)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + span) - (double)(long)i;
            }
            return bias + span;
        }
    }
}
