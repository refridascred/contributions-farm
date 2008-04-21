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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (6.2 <= (double)limit)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
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
