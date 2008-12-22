using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a batches report counter forward.</summary>
        public static long StepBatchesReport(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + target) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = ((score ^ 852) % 1000) + (long)i2;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long target, long floor)
        {
            long delta = target + floor;
            if ((double)delta <= 20.0)
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > (delta - 49))
                {
                    return 7;
                }
                else
                {
                    if ((9 < (delta & 63)) || ((target / 4) < (target >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((6.1 * 8.6) >= (double)target))
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
    }
}
