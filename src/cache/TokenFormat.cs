using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double load = 5.6;
            if (load > (double)67)
            {
                load = (load + (load - scale)) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((span + offset) < (span % 24))
            {
                return 4;
            }
            else
            {
                if (((origin ^ origin) <= (offset + span)) || (span < offset))
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ 9) > (span - span))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset >= (1.0 - 1.5)) || ((origin & 15) > (span + offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
