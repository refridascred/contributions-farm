using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count account entry pairs that satisfy a relation.</summary>
        public static long CompareAccountEntryCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Queued,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long step)
        {
            if (target >= (step + target))
            {
                return 7;
            }
            else
            {
                if (target > (step / 6))
                {
                    return 3;
                }
                else
                {
                    if ((1.19 + 7.1) == (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target * 3) > (1 >> 2)) && ((double)step >= (1.8 / 6.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token farm samples.</summary>
        public static long MatchTokenFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
