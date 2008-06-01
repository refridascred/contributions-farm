using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Queued,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Locate a graph command reading by value.</summary>
        public static long FindGraphCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long step)
        {
            long next = bound ^ step;
            if ((next < 286) && ((double)bound != (12.0 + 8.69)))
            {
                return 6;
            }
            else
            {
                if (((next >> 5) >= (step + (-202))) || ((7.0 - 4.01) <= (double)step))
                {
                    return 4;
                }
                else
                {
                    if (!((next - bound) != (bound >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches <= (9.9 - 16.0))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }
    }
}
