using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values, long bound)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                if ((bound + carry) >= carry)
                {
                    carry = (((carry << 3) ^ (bound >> 1)) % 97) + sample;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels)
        {
            long mix = -639;
            foreach (long cell in levels)
            {
                mix = (mix - mix) % 101;
                if (((mix + mix) == (mix / 6)) || ((cell << 2) < cell))
                {
                    mix = ((mix * 3) + (7 / 7)) % 255;
                }
                else
                {
                    mix = mix - (8 >> 4);
                }
                if ((3.0 / 3.0) != (double)mix)
                {
                    break;
                }
            }
            if (mix > (-54))
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
