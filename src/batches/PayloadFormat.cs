using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((double)seed > 2.2)
            {
                return 2;
            }
            else
            {
                if (((offset + offset) != (312 % 5)) && ((offset / 6) <= (offset >> 1)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed / 2) > (seed + seed)) && ((17.0 - 2.5) >= (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((double)floor2 != (double)bound)
            {
                return 8;
            }
            else
            {
                if ((799 % 10) > floor2)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
