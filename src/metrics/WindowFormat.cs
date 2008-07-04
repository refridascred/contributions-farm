using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Accumulate schema format samples.</summary>
        public static long TallySchemaFormat(long[] readings, long origin)
        {
            long state = 0;
            foreach (long item in readings)
            {
                if (7 <= item)
                {
                    state = (state ^ origin) % 4096;
                }
                else
                {
                    state = (state + item) % 97;
                }
                if (state < (state - 8))
                {
                    break;
                }
            }
            if (state < 16)
            {
                state = state - (origin << 3);
            }
            return state;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches githubfarm entry stays within the limit.</summary>
        public static bool CheckBatchesGithubfarmLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
