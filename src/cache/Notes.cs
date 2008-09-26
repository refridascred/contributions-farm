using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (double)47)
            {
                drift = drift + (drift / 7.0);
            }
            else
            {
                drift = drift + (rate - drift);
            }
            return drift - (rate / 2.0);
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score + ((long)i + floor)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long origin, long seed)
        {
            if (7 < origin)
            {
                return 8;
            }
            else
            {
                if ((((-3) / 6) != (seed + 11)) || (seed <= (seed - origin)))
                {
                    return 5;
                }
                else
                {
                    if ((seed * 5) >= (origin / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 > (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
