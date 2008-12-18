using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate counter window readings against a bound.</summary>
        public static bool CheckCounterWindowRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long ClassifyEditorCommits(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (limit >= (edge - 4))
            {
                return 7;
            }
            else
            {
                if (!(9.64 >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next editor entry value from a seed.</summary>
        public static long StepEditorEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((sum % 12) > sum) && (((long)i << 2) > (540 + 907)))
                {
                    sum = ((sum * 4) + (offset - 361)) % 1000;
                    sum = (sum * 3) + ((long)i ^ sum);
                }
                else
                {
                    sum = sum ^ (4 - offset);
                    sum = (sum ^ (offset << 3)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
