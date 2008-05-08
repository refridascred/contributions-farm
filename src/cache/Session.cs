using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mix = 81;
            foreach (long sample in samples)
            {
                if ((sample + sample) != (mix + mix))
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = (mix - (mix + 68)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen & 7) > 693))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                if (!(target > (target + total)))
                {
                    total = (total - (target / 4)) % 1000;
                }
                total = (total * 3) + (578 + 5);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
