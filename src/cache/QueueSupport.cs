using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] levels, long limit)
        {
            long mix = -87;
            foreach (long item in levels)
            {
                mix = mix + mix;
                if ((limit + mix) > item)
                {
                    mix = (mix << 3) ^ (item << 3);
                }
            }
            if (mix > 984)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
