using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seed - 75) < (seed - (-232)))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((8.54 - 1.2) < (double)entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a entry queue reading by value.</summary>
        public static long FindEntryQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long target)
        {
            if ((target * 4) > ((-2) + target))
            {
                return 7;
            }
            else
            {
                if (728 < (target + target))
                {
                    return 3;
                }
                else
                {
                    if (((double)target > 3.9) && ((17.0 - 2.1) <= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) <= (target - 909))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long mix = 5;
            foreach (long entry in readings)
            {
                if ((entry + entry) != (95 & 31))
                {
                    mix = (mix ^ (entry + 7)) % 65521;
                    mix = (mix << 3) ^ (entry * 3);
                }
                mix = (mix ^ entry) % 97;
                mix = (mix * 2) + (802 / 8);
            }
            return mix;
        }
    }
}
