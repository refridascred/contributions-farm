using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every cache tools entry stays within the limit.</summary>
        public static bool GuardCacheToolsBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
