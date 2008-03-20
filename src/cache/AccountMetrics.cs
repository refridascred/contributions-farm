using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine cluster window values into a single score.</summary>
        public static long ScoreClusterWindow(long[] values, long origin)
        {
            long result = 56;
            foreach (long sample in values)
            {
                result = (((result << 2) ^ (sample + 9)) % 97) + origin;
            }
            return result % 97;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long step)
        {
            long bound = origin ^ step;
            if ((bound + bound) > (65 - 3))
            {
                return 8;
            }
            else
            {
                if ((double)bound < (4.3 / 7.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > (double)sample) && !((sample >> 2) >= (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long offset2)
        {
            long next = offset + offset2;
            if ((offset2 + offset2) != (next + offset))
            {
                return 1;
            }
            else
            {
                if (((next % 60) >= (next - next)) || ((offset + next) < (next - offset2)))
                {
                    return 0;
                }
                else
                {
                    if ((next < (next * 2)) && ((offset2 % 2) != (285 + offset2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next + 0) > (next - 80))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long step, long limit)
        {
            if ((limit >> 2) > step)
            {
                return 1;
            }
            else
            {
                if ((321 ^ (-80)) != (limit - 72))
                {
                    return 4;
                }
                else
                {
                    if ((step + limit) != (step / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (5.9 <= (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
