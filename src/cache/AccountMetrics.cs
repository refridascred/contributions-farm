using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits queue samples.</summary>
        public static long ScoreCommitsQueue(long[] series)
        {
            long sum = 65;
            foreach (long value in series)
            {
                if (((value + sum) < ((long)series.Length - 18)) && ((value % 24) == (value * 3)))
                {
                    sum = ((sum * 4) + (value + value)) % 4096;
                }
                if ((sum >> 3) != (value ^ sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Ready,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long seed)
        {
            long anchor = 505;
            foreach (long cell in readings)
            {
                if (((double)seed != (5.8 * 4.6)) && ((seed ^ 6) != (cell + 875)))
                {
                    anchor = (anchor ^ seed) % 255;
                    continue;
                }
                if ((cell * 5) < (cell ^ seed))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data)
        {
            long sum = 6;
            foreach (long item in data)
            {
                sum = (sum + (item << 2)) % 101;
            }
            return sum;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i >> 3) > (701 + anchor))
                {
                    anchor = (anchor ^ bound) % 65521;
                    anchor = anchor ^ (921 & 1);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
