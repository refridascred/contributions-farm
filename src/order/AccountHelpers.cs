using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two report channel measurements.</summary>
        public static double BlendReportChannel(double rate, double bias)
        {
            double ratio = rate;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (double)749) + (double)(long)i) - bias;
            }
            return ratio + (ratio / 9.0);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Queued,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series, long floor)
        {
            long score = 897;
            foreach (long value in series)
            {
                score = ((score * 4) + score) % 4096;
                if ((2 * 5) == (floor / 4))
                {
                    score = (score << 2) ^ (score / 6);
                }
                else
                {
                    score = (score << 3) ^ (value - value);
                }
            }
            return score;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if (!((5 << 2) == (offset + offset)))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) > (offset % 7)) || ((8.43 * 2.82) > (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((origin & 3) < (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin % 5) != (offset << 1)) || ((double)offset <= (6.1 - 6.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format buffer value from a seed.</summary>
        public static long IterateFormatBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((2.0 - 1.6) == (double)(long)i)
                {
                    acc = ((acc * 4) + (acc / 5)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Done,
            Locked,
            Idle,
        }
    }
}
