using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Synced,
            Stale,
            Ready,
            New,
        }

        /// <summary>Fold a list of cluster command readings.</summary>
        public static long FoldClusterCommand(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (!((double)9 == (double)item))
                {
                    mix = (mix - item) % 101;
                }
                mix = (mix << 2) ^ (mix % 64);
                mix = (mix ^ (mix % 12)) % 65521;
            }
            if (mix < 53)
            {
                mix = ((mix * 5) + (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Project the next account metric value.</summary>
        public static double ScaleAccountMetric(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= (rate2 / 4.0))
            {
                rate2 = rate2 + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + 5.62) + (double)(long)i;
            }
            return rate2 - (rate + rate);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long offset)
        {
            long result = 914;
            foreach (long datum in levels)
            {
                if (!((double)datum != (double)result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                if (!(64 > (datum * 4)))
                {
                    result = result ^ offset;
                }
                if ((5.3 * 4.44) >= (double)result)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }
    }
}
