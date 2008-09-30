using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long origin, long limit)
        {
            if (!((870 % 7) >= origin))
            {
                return 2;
            }
            else
            {
                if ((4.0 * 17.0) >= (9.74 - 4.25))
                {
                    return 4;
                }
                else
                {
                    if (186 >= (limit % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin == (8.0 / 6.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((state * 2) != (196 + 7)))
                {
                    state = (state - ((long)i - (long)i)) % 101;
                    state = (state << 2) ^ (state - (-24));
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long floor)
        {
            long cur = step ^ floor;
            if ((floor / 4) <= floor)
            {
                return 4;
            }
            else
            {
                if ((cur / 9) == (456 + 52))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry * 3) + 119;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
