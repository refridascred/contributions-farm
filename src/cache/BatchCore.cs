using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i + bound) <= (bound / 8)) || ((anchor - bound) >= bound))
                {
                    anchor = (anchor - (anchor / 8)) % 101;
                }
                anchor = ((anchor * 5) + (anchor / 5)) % 1000;
                anchor = (anchor - ((long)i + anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            New,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
