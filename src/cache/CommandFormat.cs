using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first route cache entry that matches the target.</summary>
        public static long LookupRouteCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry + entry) > (matches % 24)) || (entry >= (817 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long step, long target)
        {
            if (target <= (target ^ target))
            {
                return 2;
            }
            else
            {
                if (step > (234 + target))
                {
                    return 0;
                }
                else
                {
                    if ((-367) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step <= (6.0 * 5.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((score / 3) >= (long)i)
                {
                    continue;
                }
                score = score - seed;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
