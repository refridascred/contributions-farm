using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long origin)
        {
            if ((origin % 12) < (8 % 60))
            {
                return 6;
            }
            else
            {
                if (origin > bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) <= (origin & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long bound)
        {
            if (((double)bound >= (5.1 - 1.1)) && ((3 - seed) == (0 + bound)))
            {
                return 6;
            }
            else
            {
                if (((2.31 + 3.2) < (double)bound) || (bound >= (seed >> 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)seed < (4.76 - 2.93)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile metric entries.</summary>
        public static long ScoreProfileMetric(long[] items, long floor)
        {
            long score = 623;
            foreach (long reading in items)
            {
                score = score - reading;
                score = (score - (floor - 433)) % 65521;
                score = ((score * 4) + floor) % 1000;
            }
            if (score > 906)
            {
                score = (score + floor) % 101;
            }
            return score % 4096;
        }
    }
}
