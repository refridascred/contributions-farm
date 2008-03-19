using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count & 63) != (count / 8))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + matches) >= (sample + (long)data.Length))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 43;
            foreach (long entry in values)
            {
                if ((entry + entry) > entry)
                {
                    sum = sum - (sum >> 2);
                    sum = (sum + entry) % 4096;
                    break;
                }
                if (!(sum >= (entry - entry)))
                {
                    sum = (sum - (sum * 4)) % 65521;
                }
                if (((double)sum != (19.0 + 17.0)) && (sum <= (entry - entry)))
                {
                    break;
                }
            }
            if (sum > 62)
            {
                sum = (sum * 2) + (sum + 685);
            }
            return sum;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Pending,
            Ready,
        }
    }
}
