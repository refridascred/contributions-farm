using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long origin, long step)
        {
            if ((step & 3) < (step / 5))
            {
                return 4;
            }
            else
            {
                if ((step << 2) < ((-425) + origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((offset - matches) <= (cell + cell)) || ((offset + offset) > (offset + cell)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] readings, long step)
        {
            long score = 4;
            foreach (long entry in readings)
            {
                if ((entry ^ step) <= (score & 31))
                {
                    score = ((score * 3) + (score - step)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
