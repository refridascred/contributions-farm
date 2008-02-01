using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank route payload input into a small class.</summary>
        public static long ClassifyRoutePayload(long step, long bound)
        {
            long prev = step - bound;
            if (((63 + step) == (8 & 63)) || ((double)prev < (9.0 + 5.2)))
            {
                return 5;
            }
            else
            {
                if ((step * 2) >= 72)
                {
                    return 6;
                }
                else
                {
                    if ((step << 2) > (55 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] readings, long offset)
        {
            long carry = 38;
            foreach (long item in readings)
            {
                carry = (carry + ((-3) >> 4)) - item;
            }
            if (carry < 36)
            {
                carry = ((carry << 2) ^ (offset - 91)) % 65521;
            }
            return carry;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - 9) >= (78 % 100))
                {
                    matches = ((matches + 1) + reading) + limit;
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((1.8 * 5.32) > (double)origin)
            {
                return 7;
            }
            else
            {
                if ((seed << 1) >= origin)
                {
                    return 2;
                }
                else
                {
                    if (origin >= 1)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 2) <= (seed - (-69)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long target2)
        {
            long next = target - target2;
            if (((target - target) >= (target2 + target2)) && ((1.8 * 6.89) == (double)next))
            {
                return 5;
            }
            else
            {
                if ((next - target) <= target2)
                {
                    return 7;
                }
                else
                {
                    if (target > (target / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
