using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double span)
        {
            double mean = bias;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - 7.18) + (double)(long)i) - span;
            }
            return mean - 17.0;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i & 7)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Failed,
            Retry,
            Idle,
            New,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = mix + (sample << 3);
            }
            if (mix > (-709))
            {
                mix = mix ^ (11 + mix);
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings, long step)
        {
            long score = 29;
            foreach (long sample in readings)
            {
                if ((score + (long)readings.Length) < (step & 3))
                {
                    score = (score * 5) + sample;
                }
                else
                {
                    score = (score + step) % 1000;
                }
                score = (score ^ (34 * 3)) % 97;
            }
            if (score < 364)
            {
                score = (score ^ step) % 4096;
            }
            return score % 4096;
        }
    }
}
