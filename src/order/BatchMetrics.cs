using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next githubfarm window value from a seed.</summary>
        public static long RollGithubfarmWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc * 4) + ((long)i - acc);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Queued,
            New,
            Failed,
        }

        /// <summary>Measure how many filter payload samples are out of range.</summary>
        public static long CountFilterPayloadHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length < count)
                {
                    count = ((count + 2) - value) + seed;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long step, long offset)
        {
            long diff = step ^ offset;
            if ((offset - step) < (146 + offset))
            {
                return 8;
            }
            else
            {
                if ((step * 4) > (step - diff))
                {
                    return 4;
                }
                else
                {
                    if ((step + offset) >= (diff << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
