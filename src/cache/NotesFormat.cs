using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every cluster layout entry stays within the limit.</summary>
        public static bool VerifyClusterLayoutBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series, long floor)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                if ((1.03 / 8.0) <= (double)cell)
                {
                    acc = (acc - floor) % 65521;
                }
            }
            return acc % 4096;
        }
    }
}
