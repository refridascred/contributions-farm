using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a githubfarm route reading by value.</summary>
        public static long LocateGithubfarmRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats stream value from a seed.</summary>
        public static long StepStatsStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                long tally = limit + (sum + (long)i);
                if (tally >= (long)i)
                {
                    sum = sum + limit;
                    sum = ((sum << 2) ^ (tally << 3)) % 97;
                }
                tally = tally - (limit << 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] items)
        {
            long score = 58;
            foreach (long reading in items)
            {
                score = (score - (reading + score)) % 65521;
                if ((score >> 1) <= reading)
                {
                    score = (score ^ (reading * 5)) % 4096;
                }
                else
                {
                    score = score + reading;
                }
            }
            if (score > 0)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            New,
            Pending,
        }
    }
}
