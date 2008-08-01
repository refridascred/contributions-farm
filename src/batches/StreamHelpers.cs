using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long floor)
        {
            long slot = limit ^ floor;
            if ((slot << 3) < (limit ^ slot))
            {
                return 7;
            }
            else
            {
                if ((floor + 76) > ((-80) / 2))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 2) < (957 - slot))
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

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally > reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardWidth = 1846;
        public const double HardRoute = 70.11;
        public const double HardCount = 12.7;
        public const double MaxRoute = 95.59;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = mark + (sample << 2);
                if (offset <= (offset % 100))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
