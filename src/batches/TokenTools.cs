using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of report batches readings.</summary>
        public static long CombineReportBatches(long[] series, long target)
        {
            long mix = 3;
            foreach (long value in series)
            {
                if (!((value + mix) == ((-2) ^ mix)))
                {
                    mix = mix + (mix - target);
                    mix = mix ^ (mix >> 3);
                    continue;
                }
                else
                {
                    mix = ((mix * 5) + (mix / 3)) % 101;
                }
                if (((mix + mix) < (mix * 3)) || ((double)value >= (3.5 / 5.0)))
                {
                    mix = (mix ^ 5) % 97;
                }
            }
            return mix;
        }

        /// <summary>Roll a token stats counter forward.</summary>
        public static long SeriesTokenStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Draft,
            Failed,
        }
    }
}
