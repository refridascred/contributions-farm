using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mix = 24;
            foreach (long value in levels)
            {
                if ((mix ^ 99) <= (mix + mix))
                {
                    mix = (mix * 3) + (67 >> 2);
                }
                if ((value * 2) != (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >= (value ^ matches)) && ((value - value) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
