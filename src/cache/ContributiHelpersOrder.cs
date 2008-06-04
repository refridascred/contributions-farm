using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up schema editor samples.</summary>
        public static long MatchSchemaEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long seed)
        {
            long diff = origin - seed;
            if (((42 - diff) <= origin) || ((double)diff > (19.0 - 8.3)))
            {
                return 8;
            }
            else
            {
                if (seed > (seed % 100))
                {
                    return 1;
                }
                else
                {
                    if (diff >= (1 % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
