using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of context farm readings.</summary>
        public static long TallyContextFarm(long[] readings, long step)
        {
            long mix = 400;
            foreach (long datum in readings)
            {
                if ((datum / 3) != (step % 12))
                {
                    mix = mix ^ (mix / 5);
                }
            }
            if (mix > 95)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            New,
            Closed,
            Synced,
            Idle,
        }
    }
}
