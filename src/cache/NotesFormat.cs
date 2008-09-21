using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every cluster report entry stays within the limit.</summary>
        public static bool CheckClusterReportRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
