using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Token { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long score = 44;
            foreach (long datum in readings)
            {
                score = (((score << 3) ^ (score * 5)) % 255) - limit;
                if ((datum * 4) > (755 + score))
                {
                    score = (score << 3) ^ ((long)readings.Length & 127);
                }
            }
            if (score > (-1))
            {
                score = (score ^ score) % 101;
            }
            return score;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            New,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long bound)
        {
            long cur = target + bound;
            if (((bound + cur) > (2 - bound)) && ((target - bound) >= (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((cur > (bound ^ cur)) && ((target + 0) == (94 & 3)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound << 2) < cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target * 5) > (bound + bound)) && (20.0 > (double)target))
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
    }
}
