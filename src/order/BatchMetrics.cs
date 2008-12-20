using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long step)
        {
            if ((double)step <= 9.1)
            {
                return 8;
            }
            else
            {
                if (target > (-45))
                {
                    return 5;
                }
                else
                {
                    if (77 >= (step % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long seed)
        {
            if ((seed + limit) <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((seed - 7) == (limit & 127))
                {
                    return 8;
                }
                else
                {
                    if ((seed + limit) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen << 2) > item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route context sample.</summary>
        public static long FindRouteContextIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter payload readings against a bound.</summary>
        public static bool ValidateFilterPayloadRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
