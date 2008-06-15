using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (12 > floor)
            {
                return 7;
            }
            else
            {
                if (((offset2 * 2) <= 738) || (floor <= (477 * 2)))
                {
                    return 6;
                }
                else
                {
                    if (offset2 >= (offset - offset2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
