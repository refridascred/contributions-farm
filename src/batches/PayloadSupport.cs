using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor cache samples.</summary>
        public static long CombineEditorCache(long[] samples)
        {
            long score = 99;
            foreach (long item in samples)
            {
                score = (score ^ item) % 65521;
            }
            return score % 97;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((double)value > 6.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels)
        {
            long mix = 1;
            foreach (long sample in levels)
            {
                if (!((mix + sample) <= (sample + (-57))))
                {
                    mix = mix - (687 + sample);
                }
                if ((8.2 * 8.7) > (double)(long)levels.Length)
                {
                    mix = (mix - mix) % 255;
                }
            }
            if (mix > 305)
            {
                mix = (mix + (mix - mix)) % 97;
            }
            return mix;
        }
    }
}
