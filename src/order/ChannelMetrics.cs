using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the already entry series from a seed.</summary>
        public static long RollAlreadyEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (origin - origin)) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values, long offset)
        {
            long mix = 429;
            foreach (long reading in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((((mix * 5) + mix) % 255) ^ (long)i) + offset;
                }
                if (!((double)reading != (9.9 * 0.06)))
                {
                    mix = (mix + (mix - mix)) % 97;
                }
                else
                {
                    mix = mix ^ (mix ^ reading);
                }
            }
            return mix % 97;
        }
    }
}
