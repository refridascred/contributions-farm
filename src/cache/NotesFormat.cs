using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up graph cluster samples.</summary>
        public static long OverlapGraphClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long floor)
        {
            long gap = seed + floor;
            if ((460 ^ seed) > seed)
            {
                return 8;
            }
            else
            {
                if ((974 * 5) >= gap)
                {
                    return 1;
                }
                else
                {
                    if ((gap % 100) < (83 & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - gap) > gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm queue entry stays within the limit.</summary>
        public static bool VerifyGithubfarmQueueBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
