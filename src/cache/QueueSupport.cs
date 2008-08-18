using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long limit, long target)
        {
            if (limit <= (limit / 5))
            {
                return 1;
            }
            else
            {
                if (((limit ^ target) < (target % 5)) && ((double)target <= (double)8))
                {
                    return 2;
                }
                else
                {
                    if (target >= (74 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = state - (target * 3);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double weight = (13.0 + 19.0) / 6.0;
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (offset - rate);
        }
    }
}
