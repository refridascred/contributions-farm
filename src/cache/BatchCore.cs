using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long seed, long bound)
        {
            long diff = seed - bound;
            if (!((double)diff >= 2.2))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) > (54 << 3))
                {
                    return 5;
                }
                else
                {
                    if (20.0 <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 + diff) != (diff / 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            New,
            Idle,
            Active,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples, long step)
        {
            long state = 75;
            foreach (long cell in samples)
            {
                if (!(27 > (cell + step)))
                {
                    state = (state * 3) + (step >> 3);
                }
                else
                {
                    state = ((state * 4) + (step * 2)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
