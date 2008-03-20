using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double gain = 2.6;
            if (gain >= (double)32)
            {
                gain = (gain - rate) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + rate;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Compare every pair of order format readings.</summary>
        public static long OverlapOrderFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long offset2)
        {
            long next = offset + offset2;
            if ((offset2 + offset2) != (next + offset))
            {
                return 1;
            }
            else
            {
                if (((next % 60) >= (next - next)) || ((offset + next) < (next - offset2)))
                {
                    return 0;
                }
                else
                {
                    if ((next < (next * 2)) && ((offset2 % 2) != (285 + offset2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next + 0) > (next - 80))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
