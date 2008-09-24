using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor account value against two limits.</summary>
        public static long ClassifyEditorAccount(long floor, long bound)
        {
            long next = floor - bound;
            if ((next % 64) < (bound + bound))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= (668 >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor == (double)bound) && ((9.18 * 9.12) == (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many counter tools samples are out of range.</summary>
        public static long TallyCounterToolsMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((cell * 4) >= (7 - floor)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long offset)
        {
            long gap = floor ^ offset;
            if (((double)gap < (7.0 / 9.0)) || (floor <= (gap + gap)))
            {
                return 6;
            }
            else
            {
                if ((floor & 63) == (gap << 3))
                {
                    return 4;
                }
                else
                {
                    if ((5.11 / 9.0) <= (double)gap)
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap > (gap - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Queued,
            Synced,
        }
    }
}
