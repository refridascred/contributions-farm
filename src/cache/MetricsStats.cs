using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Synced,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long AuditRecordOrderHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((13.0 + 3.9) >= (double)target)
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings)
        {
            long carry = 16;
            foreach (long sample in readings)
            {
                carry = carry - (sample + (-755));
                if ((carry - carry) == (353 + carry))
                {
                    carry = (carry << 2) ^ (carry * 3);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry << 1)) % 4096;
                }
            }
            if (carry < 879)
            {
                carry = (carry ^ carry) % 97;
            }
            return carry % 97;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if ((8.41 + 3.72) == (double)seed2)
            {
                return 6;
            }
            else
            {
                if ((double)bound >= 9.77)
                {
                    return 5;
                }
                else
                {
                    if (6.7 <= (double)seed2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a cluster profile pair into a bucket.</summary>
        public static long SortClusterProfile(long step, long origin)
        {
            long delta = step ^ origin;
            if (((double)step != (2.57 - 5.5)) && ((step << 3) <= step))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (5.0 + 7.36))
                {
                    return 2;
                }
                else
                {
                    if (delta >= (step % 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
