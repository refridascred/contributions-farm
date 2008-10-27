using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter commits samples.</summary>
        public static long ScoreCounterCommits(long[] data, long step)
        {
            long score = 9;
            foreach (long cell in data)
            {
                score = score + score;
                score = (score - (403 << 3)) % 4096;
                if ((score & 3) != (cell + score))
                {
                    score = ((score * 5) + (cell + step)) % 65521;
                }
                if (!((74 / 4) <= cell))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Ready,
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double mean = (double)4;
            if (mean > 1.81)
            {
                mean = (mean - (gain + gain)) - offset;
            }
            else
            {
                mean = mean + (mean / 3.0);
            }
            return mean - (gain + mean);
        }
    }
}
