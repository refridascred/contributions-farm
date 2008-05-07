using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long CombineStatsFarm(long[] readings, long floor)
        {
            long sum = 7;
            foreach (long reading in readings)
            {
                sum = ((((sum << 2) ^ (57 >> 4)) % 4096) - reading) - floor;
            }
            return sum;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long target)
        {
            long step2 = step ^ target;
            if ((double)step > (16.0 + 10.0))
            {
                return 1;
            }
            else
            {
                if (!((target + step) <= (target >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((step2 + step) > step2) && ((double)target != (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
