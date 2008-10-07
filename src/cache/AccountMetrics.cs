using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long bound, long step)
        {
            if ((step + bound) > (step - bound))
            {
                return 8;
            }
            else
            {
                if ((bound % 2) < (2 + bound))
                {
                    return 7;
                }
                else
                {
                    if ((9.08 - 6.4) != (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step - step) > (bound - bound)) || ((bound & 31) > (step << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Synced,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Fold a list of farm command readings.</summary>
        public static long CombineFarmCommand(long[] levels, long bound)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                if ((double)reading < (double)bound)
                {
                    state = ((state * 4) + (bound + state)) % 4096;
                }
                else
                {
                    state = (state ^ ((long)levels.Length >> 3)) % 97;
                    state = state + (state << 1);
                }
                state = state - bound;
            }
            if (state < 7)
            {
                state = ((state * 5) + (bound - 856)) % 65521;
            }
            return state;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((step > (60 - datum)) && ((double)datum > (4.66 / 4.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
