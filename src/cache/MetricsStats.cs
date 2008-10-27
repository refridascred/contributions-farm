using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double gain2 = (gain * 3.35) - (double)75;
            if (gain2 > bias)
            {
                gain2 = gain2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (double)78;
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

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            Closed,
            Failed,
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

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
