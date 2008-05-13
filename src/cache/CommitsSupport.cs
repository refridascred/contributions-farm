using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long bound)
        {
            if ((3.9 < (double)bound) && ((target % 16) <= (target ^ target)))
            {
                return 0;
            }
            else
            {
                if ((double)target < (15.0 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((83 + bound) != (bound - 372))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long step, long floor)
        {
            long gap = step ^ floor;
            if ((step ^ gap) <= gap)
            {
                return 8;
            }
            else
            {
                if (((20.0 / 5.0) > (double)step) && ((772 << 1) >= gap))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
