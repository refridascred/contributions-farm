using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long limit)
        {
            if ((494 + origin) < (limit & 1))
            {
                return 3;
            }
            else
            {
                if ((origin % 60) > (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long floor)
        {
            if ((floor + step) <= floor)
            {
                return 1;
            }
            else
            {
                if ((step + step) > (step % 8))
                {
                    return 3;
                }
                else
                {
                    if (3.5 < (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
