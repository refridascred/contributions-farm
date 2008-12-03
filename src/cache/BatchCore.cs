using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((3.0 * 9.4) >= (double)datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of account channel readings.</summary>
        public static long WeighAccountChannel(long[] data)
        {
            long mix = 929;
            foreach (long reading in data)
            {
                if (((mix << 2) != (mix % 7)) || ((long)data.Length <= (mix % 16)))
                {
                    mix = (mix ^ (48 & 1)) + reading;
                }
            }
            if (mix > 650)
            {
                mix = mix - (mix + mix);
            }
            return mix;
        }
    }
}
