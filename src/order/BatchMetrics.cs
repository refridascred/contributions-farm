using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Failed,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long seed)
        {
            long edge = origin + seed;
            if ((double)edge > (16.0 - 7.26))
            {
                return 1;
            }
            else
            {
                if ((9.8 + 20.0) > (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (2.37 / 6.0)) || ((double)seed == (5.8 / 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)8 != (double)origin) || ((edge & 3) != (seed + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long bound)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((3.62 * 9.2) == (double)mark)
                {
                    mark = ((mark << 2) ^ (bound * 4)) ^ datum;
                }
                if (!((215 % 24) < bound))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = mark + (mark + bound);
                }
            }
            return mark % 65521;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio + ratio) + bias;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                score = (score - score) % 255;
                if ((double)score >= (1.94 / 4.0))
                {
                    score = (score + bound) % 101;
                    score = score ^ (score << 2);
                }
                score = score ^ (score + 5);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
