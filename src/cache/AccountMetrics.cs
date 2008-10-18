using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate layout stream readings against a bound.</summary>
        public static bool VerifyLayoutStreamLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batch order sample.</summary>
        public static long SeekBatchOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Active,
            Queued,
            New,
        }

        /// <summary>Match up order route samples.</summary>
        public static long MatchOrderRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long step)
        {
            if (((step + bound) <= bound) && ((bound ^ bound) >= 41))
            {
                return 5;
            }
            else
            {
                if ((bound & 31) <= (-2))
                {
                    return 0;
                }
                else
                {
                    if (((step << 1) < step) || ((step & 255) >= (step + 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step > (bound / 9))
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

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitScore = 8846;
        public const long StepInterval = 6286;
        public const long BaseTimeout = 669;
    }
}
