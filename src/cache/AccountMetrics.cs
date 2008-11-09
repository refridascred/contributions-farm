using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long origin, long seed)
        {
            if ((seed + seed) < (251 << 3))
            {
                return 8;
            }
            else
            {
                if (((seed >> 2) > (origin ^ origin)) && ((double)seed != (3.6 / 6.0)))
                {
                    return 3;
                }
                else
                {
                    if (4.7 >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.1 + 17.0) <= (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Derive the next queue notes value from a seed.</summary>
        public static long StepQueueNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - (seed >> 2)) % 1000;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)floor > (double)3)
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
