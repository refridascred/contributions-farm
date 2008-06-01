using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)offset != (7.5 - 8.4))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] levels, long limit)
        {
            long score = 95;
            foreach (long reading in levels)
            {
                if (((reading + score) == (score ^ limit)) || ((reading % 97) < limit))
                {
                    score = score - (limit - limit);
                }
                if (((score - limit) > (reading / 3)) || ((limit - 47) <= reading))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the context channel entries that pass the check.</summary>
        public static long AuditContextChannelMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count <= (bound + bound))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample >= ((long)values.Length % 3)) && ((seed - 41) >= (hits >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine payload checks values into a single score.</summary>
        public static long TotalPayloadChecks(long[] data, long step)
        {
            long result = 7;
            foreach (long reading in data)
            {
                result = (((result * 3) + (result ^ reading)) % 4096) + step;
            }
            return result;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
