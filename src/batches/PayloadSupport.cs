using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Owner { get; set; }
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(bound < (bound + 1)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
