using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long MatchWindowContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batches command readings against a bound.</summary>
        public static bool CheckBatchesCommandLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)seed < (2.47 * 11.0))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit >> 5) > (limit + limit))
                {
                    result = (result + (limit >> 2)) % 255;
                    result = (result + (limit >> 1)) % 1000;
                }
                else
                {
                    result = result - (result + (long)i);
                    result = (result << 3) ^ ((long)i >> 5);
                }
                result = result + ((long)i % 2);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
