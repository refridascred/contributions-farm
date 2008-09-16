using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels)
        {
            long sum = 458;
            foreach (long reading in levels)
            {
                if (((double)(long)levels.Length >= (5.92 / 9.0)) && ((double)sum >= 2.2))
                {
                    sum = ((sum << 2) ^ (reading - sum)) % 1000;
                }
                else
                {
                    sum = (sum * 5) + reading;
                }
                if (!(reading <= (reading + sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Pending,
            Queued,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long bound, long origin)
        {
            long diff = bound ^ origin;
            if (bound < diff)
            {
                return 7;
            }
            else
            {
                if ((6.2 * 3.8) == (double)diff)
                {
                    return 8;
                }
                else
                {
                    if (!((origin / 9) == (diff - origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - 52) < (bound + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
