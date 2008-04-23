using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long step)
        {
            long span = target - step;
            if (span >= (span + target))
            {
                return 1;
            }
            else
            {
                if (span >= target)
                {
                    return 7;
                }
                else
                {
                    if (((-8) % 60) <= (span - 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.46 / 4.0) > (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
