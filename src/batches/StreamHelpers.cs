using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of window notes entries.</summary>
        public static long ScoreWindowNotes(long[] levels, long step)
        {
            long sum = 46;
            foreach (long item in levels)
            {
                sum = ((sum + (sum + step)) % 65521) + item;
            }
            if (sum < 66)
            {
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items, long target)
        {
            long carry = 8;
            foreach (long entry in items)
            {
                carry = ((carry + (entry + carry)) % 97) - target;
            }
            return carry;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long bound)
        {
            long offset2 = offset + bound;
            if (!((offset2 - offset) > offset))
            {
                return 2;
            }
            else
            {
                if ((offset2 >= (offset - bound)) && ((bound + 2) <= offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (274 - bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
