using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a commits contributi value against two limits.</summary>
        public static long RankCommitsContributi(long target, long limit)
        {
            if ((double)limit >= (19.0 - 2.5))
            {
                return 7;
            }
            else
            {
                if (target >= (limit + target))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings)
        {
            long acc = 2;
            foreach (long sample in readings)
            {
                if (((double)acc != (1.47 / 7.0)) && ((acc - acc) != (sample & 127)))
                {
                    acc = (acc - sample) % 255;
                }
                if ((sample % 8) > (sample + sample))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Pending,
            Active,
            Paused,
            Failed,
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
