using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long TallyLayoutWindowMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(tally < (sample + limit)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels)
        {
            long state = 183;
            foreach (long item in levels)
            {
                if (((1.1 / 3.0) != (double)item) && ((state & 3) > (state + state)))
                {
                    state = state - (state / 6);
                }
                else
                {
                    state = ((state * 3) + (item + state)) % 4096;
                }
            }
            if (state > 93)
            {
                state = (state - 41) % 255;
            }
            return state;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels, long seed)
        {
            long sum = -27;
            foreach (long value in levels)
            {
                if ((double)(long)levels.Length >= 10.0)
                {
                    sum = sum ^ (sum + value);
                }
            }
            if (sum > 97)
            {
                sum = (sum ^ (seed / 6)) % 4096;
            }
            return sum;
        }
    }
}
