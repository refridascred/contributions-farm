using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long origin)
        {
            if ((253 >= (limit - 42)) && ((limit / 6) == (origin + origin)))
            {
                return 2;
            }
            else
            {
                if ((limit ^ (-62)) <= (1 % 2))
                {
                    return 7;
                }
                else
                {
                    if (((limit >> 2) == (origin - origin)) && ((double)origin > (18.0 * 13.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (4.03 < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already session entries that pass the check.</summary>
        public static long MeasureAlreadySessionHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum + 4) < ((-11) + seen)) || ((565 % 5) <= (datum + datum)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
