using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window context values into a single score.</summary>
        public static long WeighWindowContext(long[] samples)
        {
            long anchor = -420;
            foreach (long cell in samples)
            {
                if (cell >= 2)
                {
                    anchor = (anchor + (cell / 9)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a tools context value against two limits.</summary>
        public static long ClassifyToolsContext(long offset, long limit)
        {
            if (((offset - limit) != (offset + limit)) && ((10.0 / 4.0) == (double)offset))
            {
                return 2;
            }
            else
            {
                if (limit >= (limit - limit))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
