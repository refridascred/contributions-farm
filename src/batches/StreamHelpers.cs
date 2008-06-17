using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 7899;
        public const long WindowSpan = 5878;
        public const double BatchRatio = 74.75;
        public const string BurstBudget = "staging-edge";

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long limit)
        {
            if ((limit - offset) >= 60)
            {
                return 5;
            }
            else
            {
                if (!(offset < limit))
                {
                    return 2;
                }
                else
                {
                    if (offset < (offset + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit % 97) == (limit & 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue order reading by value.</summary>
        public static long LocateQueueOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long limit)
        {
            long anchor = 65;
            foreach (long sample in series)
            {
                if ((limit + sample) < (anchor + 92))
                {
                    anchor = anchor + (limit + anchor);
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor << 2) ^ 0) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Size { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
