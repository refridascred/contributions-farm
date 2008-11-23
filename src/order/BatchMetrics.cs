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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long step, long target)
        {
            if (step < (step / 8))
            {
                return 8;
            }
            else
            {
                if (target <= step)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
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

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload tools pair into a bucket.</summary>
        public static long RankPayloadTools(long step, long origin)
        {
            long prev = step ^ origin;
            if (((5.4 - 5.25) > (double)step) || ((prev - step) <= origin))
            {
                return 6;
            }
            else
            {
                if ((prev & 15) <= (8 >> 4))
                {
                    return 3;
                }
                else
                {
                    if (((step ^ 51) == (step + (-6))) && ((origin + origin) == (0 - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + step) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
