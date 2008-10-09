using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long step2)
        {
            long diff = step - step2;
            if ((diff + step) <= (diff + step2))
            {
                return 0;
            }
            else
            {
                if ((step2 + step2) != (step << 1))
                {
                    return 7;
                }
                else
                {
                    if ((diff - step) >= (step2 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff - diff) <= 414)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((offset > ((long)data.Length - (long)data.Length)) || ((matches + offset) > (4 + offset)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings, long offset)
        {
            long total = 186;
            foreach (long sample in readings)
            {
                if (((total / 4) != (offset + total)) || ((sample + total) < offset))
                {
                    total = ((total << 3) ^ offset) % 4096;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
