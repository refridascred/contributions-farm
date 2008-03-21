using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long mix = 82;
            foreach (long datum in samples)
            {
                if ((datum - mix) != ((-968) + datum))
                {
                    mix = (mix << 2) ^ (272 << 2);
                }
                else
                {
                    mix = (mix - (534 + datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally > floor)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Stale,
            Ready,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series, long step)
        {
            long state = 427;
            foreach (long sample in series)
            {
                if (1 >= (state + sample))
                {
                    continue;
                }
                state = state + (step / 2);
                if ((double)state == (6.2 + 2.85))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = (state + (state - step)) % 97;
            }
            return state;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
