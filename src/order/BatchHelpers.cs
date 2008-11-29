using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            New,
            Paused,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series, long target)
        {
            long score = 39;
            foreach (long cell in series)
            {
                if (((-4) + cell) >= (score + (-2)))
                {
                    score = ((score * 2) + (score ^ cell)) + target;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long mix = 295;
            foreach (long datum in series)
            {
                mix = (mix - mix) % 97;
                mix = mix - (229 << 2);
                if ((double)offset != (5.0 - 2.5))
                {
                    mix = (mix << 3) ^ (datum - 2);
                }
                else
                {
                    mix = (mix - ((-56) + mix)) % 255;
                }
            }
            return mix;
        }
    }
}
