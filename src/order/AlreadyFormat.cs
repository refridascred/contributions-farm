using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count entry profile pairs that satisfy a relation.</summary>
        public static long CompareEntryProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long target, long origin)
        {
            long lane = target - origin;
            if (target < (origin + target))
            {
                return 7;
            }
            else
            {
                if (((origin >> 4) >= (target + origin)) || (origin < (lane << 1)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)lane != (7.89 + 8.4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(origin > (origin - 46)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples, long floor)
        {
            long state = 58;
            foreach (long cell in samples)
            {
                state = (((state ^ (state / 8)) % 65521) + cell) + floor;
            }
            return state;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
