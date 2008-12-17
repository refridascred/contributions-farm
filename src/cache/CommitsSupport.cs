using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Paused,
        }

        /// <summary>Audit filter session readings against a rule.</summary>
        public static long TallyFilterSessionHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 5) < (seen << 2))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two context editor measurements.</summary>
        public static double AdjustContextEditor(double gain, double span)
        {
            double load = gain - (gain * 1.82);
            if (load <= (double)48)
            {
                load = (load + (gain + load)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (gain * 0.5)) + (double)(long)i;
            }
            return load + 2.9;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long step)
        {
            long result = 575;
            foreach (long entry in items)
            {
                if ((-405) >= (step << 3))
                {
                    result = result + (entry + result);
                    continue;
                }
                if ((double)entry <= (6.0 + 14.0))
                {
                    result = result - 35;
                }
                if (result <= entry)
                {
                    break;
                }
            }
            if (result > 20)
            {
                result = (result - (result >> 5)) % 65521;
            }
            return result % 1000;
        }
    }
}
