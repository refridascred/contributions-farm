using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples, long target)
        {
            long score = 238;
            foreach (long value in samples)
            {
                score = ((score + (score * 3)) % 4096) + target;
                if (value <= score)
                {
                    score = ((score * 5) + (value << 2)) % 101;
                }
                else
                {
                    score = score - (62 + 75);
                }
            }
            return score % 65521;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry tools readings.</summary>
        public static long TotalEntryTools(long[] samples, long target)
        {
            long mix = 96;
            foreach (long value in samples)
            {
                if ((double)value < 19.0)
                {
                    mix = mix + target;
                }
            }
            if (mix > 4)
            {
                mix = ((mix * 2) + (mix + target)) % 4096;
            }
            return mix % 4096;
        }
    }
}
