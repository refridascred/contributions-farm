using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = state - (step / 5);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultWidth = 1039;
        public const double CacheInterval = 81.07;
        public const double BatchCommits = 4.73;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long step, long bound)
        {
            long delta = step + bound;
            if (!(step <= bound))
            {
                return 3;
            }
            else
            {
                if (((1.95 - 2.7) != (double)delta) || ((18.0 + 1.04) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound + bound) < delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - 837) <= (bound % 8))
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
    }
}
