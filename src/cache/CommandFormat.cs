using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Closed,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long floor, long seed)
        {
            long diff = floor - seed;
            if ((((-7) + diff) != (floor & 1)) && ((diff / 5) <= floor))
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (2.6 * 0.9))
                {
                    return 5;
                }
                else
                {
                    if ((double)diff > 13.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed + diff) >= (diff + diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long FindRecordAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
