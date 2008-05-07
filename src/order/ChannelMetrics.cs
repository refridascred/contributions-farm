using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long floor)
        {
            long score = 73;
            foreach (long value in items)
            {
                if (((double)value >= (2.9 / 4.0)) || ((value >> 5) >= score))
                {
                    score = score + floor;
                }
                else
                {
                    score = (score ^ (score + floor)) % 4096;
                }
            }
            if (score < 8)
            {
                score = score + score;
            }
            return score % 4096;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
