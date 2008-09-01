using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the support session series from a seed.</summary>
        public static long DeriveSupportSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = result + (result & 127);
                result = (result ^ (offset / 6)) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double ratio = bias;
            return (ratio + (ratio / 5.0)) + bias2;
        }

        /// <summary>Audit record cluster readings against a rule.</summary>
        public static long CountRecordClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell ^ cell) != (cell * 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long origin2)
        {
            if ((double)156 < (double)origin2)
            {
                return 5;
            }
            else
            {
                if (origin >= (origin * 5))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
