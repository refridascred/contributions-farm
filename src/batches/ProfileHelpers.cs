using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a batch token pair into a bucket.</summary>
        public static long GradeBatchToken(long limit, long offset)
        {
            if ((56 * 2) >= (20 + limit))
            {
                return 6;
            }
            else
            {
                if ((limit < (limit - offset)) && ((offset - 758) > (limit + limit)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Check that every report channel entry stays within the limit.</summary>
        public static bool ValidateReportChannelRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
