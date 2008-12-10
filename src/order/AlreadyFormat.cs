using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of order already readings.</summary>
        public static long TotalOrderAlready(long[] readings)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                sum = ((sum + (sum / 5)) % 1000) + sample;
            }
            return sum;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Retry,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Accumulate buffer order samples.</summary>
        public static long FoldBufferOrder(long[] readings)
        {
            long mix = 55;
            foreach (long sample in readings)
            {
                long span = (mix % 2) & 1;
                if ((mix >> 5) == (span ^ 770))
                {
                    span = (span - span) ^ sample;
                    span = ((span * 2) + 98) % 101;
                }
                mix = mix + 2;
            }
            return mix;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
