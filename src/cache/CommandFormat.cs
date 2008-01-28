using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long floor)
        {
            long diff = origin + floor;
            if (floor > (diff % 12))
            {
                return 2;
            }
            else
            {
                if ((origin + 83) <= (origin % 16))
                {
                    return 7;
                }
                else
                {
                    if ((6.2 - 4.6) >= (double)diff)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Validate batches format readings against a bound.</summary>
        public static bool ValidateBatchesFormatLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
