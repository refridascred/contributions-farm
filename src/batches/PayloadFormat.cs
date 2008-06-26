using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((20.0 / 7.0) > (double)sum))
                {
                    sum = (sum << 2) ^ ((long)i / 9);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long step)
        {
            if ((step % 24) <= (step % 8))
            {
                return 4;
            }
            else
            {
                if ((step - floor) == (71 - floor))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ 833) <= (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((265 * 2) < (step >> 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
