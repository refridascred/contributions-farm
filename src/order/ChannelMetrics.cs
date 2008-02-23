using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((9.2 - 0.74) > (double)mix)
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series)
        {
            long mark = 33;
            foreach (long sample in series)
            {
                if ((383 + sample) <= (sample + mark))
                {
                    mark = mark - (sample - mark);
                }
                if (mark <= (mark / 4))
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ (mark << 1)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Idle,
            Done,
            New,
        }
    }
}
