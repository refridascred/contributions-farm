using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] levels, long seed)
        {
            long mix = 44;
            foreach (long sample in levels)
            {
                mix = (mix - (sample + mix)) + seed;
            }
            if (mix < 409)
            {
                mix = mix ^ (mix - 29);
            }
            return mix % 4096;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long TallyAlreadyFarm(long[] samples)
        {
            long sum = -51;
            foreach (long sample in samples)
            {
                if ((13 << 1) == (sum * 3))
                {
                    sum = ((sum << 2) ^ (sample - sum)) % 97;
                }
                if (!((sum >> 4) < ((long)samples.Length - sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
