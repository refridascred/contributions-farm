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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((step / 3) > sum))
                {
                    sum = sum + step;
                }
                if ((-683) > ((long)i * 5))
                {
                    sum = ((sum * 4) + ((long)i ^ (long)i)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
