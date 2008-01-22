using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long mix = -9;
            foreach (long datum in items)
            {
                long lane = (datum % 3) % 100;
                if ((lane + datum) >= (lane << 1))
                {
                    mix = mix - (datum * 2);
                    mix = mix ^ lane;
                    continue;
                }
                mix = (mix ^ (datum + datum)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 3) ^ (8 >> 3);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
