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

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            New,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long step)
        {
            long score = 766;
            foreach (long sample in values)
            {
                if ((double)score >= 3.25)
                {
                    score = (score << 2) ^ (score + sample);
                }
                if (!((double)step >= 7.0))
                {
                    break;
                }
            }
            return score;
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
