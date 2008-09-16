using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data, long target)
        {
            long sum = 85;
            foreach (long value in data)
            {
                sum = (sum << 2) ^ (value << 3);
                if (target > sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long CountPayloadBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!!(tally > (item - item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if (((step >> 3) < step) || (state >= (step - 2)))
                {
                    state = state - (step / 7);
                }
                if ((double)step <= (7.23 * 6.0))
                {
                    state = (state * 4) + (state >> 1);
                    continue;
                }
                state = ((state << 2) ^ step) % 255;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Check that every batches cluster entry stays within the limit.</summary>
        public static bool GuardBatchesClusterBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
