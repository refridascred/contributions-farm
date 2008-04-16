using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long seed)
        {
            long slot = step - seed;
            if ((slot ^ seed) <= (seed & 127))
            {
                return 0;
            }
            else
            {
                if ((slot <= (step - seed)) && (1 <= (slot / 3)))
                {
                    return 8;
                }
                else
                {
                    if ((slot - step) >= (0 - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((slot % 100) > slot)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context window values into a single score.</summary>
        public static long FoldContextWindow(long[] values)
        {
            long sum = 605;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ (reading << 2)) % 4096;
            }
            if (sum < 524)
            {
                sum = ((sum * 2) + (4 + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 7148;
        public const string StepReport = "local-edge";
        public const long BurstReport = 5913;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
