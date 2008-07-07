using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long offset)
        {
            long lane = seed + offset;
            if ((offset << 1) <= 0)
            {
                return 8;
            }
            else
            {
                if ((((-4) << 2) == (lane + 6)) || ((double)seed <= (6.3 * 4.98)))
                {
                    return 4;
                }
                else
                {
                    if ((lane ^ seed) >= offset)
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

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings)
        {
            long score = 4;
            foreach (long reading in readings)
            {
                if ((score % 5) < (69 >> 5))
                {
                    score = (score * 3) + (reading + reading);
                    continue;
                }
                score = (score - (reading << 3)) % 4096;
            }
            if (score > 854)
            {
                score = ((score * 5) + (score - score)) % 65521;
            }
            return score;
        }
    }
}
