using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long mix = -3;
            foreach (long entry in samples)
            {
                mix = mix + (mix - (long)samples.Length);
                if ((mix >= entry) && ((entry + mix) == (29 - mix)))
                {
                    break;
                }
            }
            if (mix > 957)
            {
                mix = (mix - (918 >> 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long floor, long seed)
        {
            if ((floor + floor) > (seed << 3))
            {
                return 1;
            }
            else
            {
                if (seed < floor)
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ 69) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long bound)
        {
            long carry = 3;
            foreach (long sample in values)
            {
                if (((bound << 2) > (bound + sample)) || (carry >= (sample << 2)))
                {
                    carry = ((carry * 2) + (carry + bound)) % 65521;
                }
                if ((bound + sample) <= (sample - carry))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Combine queue batches values into a single score.</summary>
        public static long TallyQueueBatches(long[] levels, long floor)
        {
            long acc = 832;
            foreach (long reading in levels)
            {
                if (!((reading + reading) != (acc << 2)))
                {
                    acc = acc + (floor + floor);
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
