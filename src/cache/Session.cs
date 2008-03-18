using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a route batch counter forward.</summary>
        public static long StepRouteBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + ((long)i - total)) % 65521;
                total = ((total * 5) + (target + target)) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a commits command value against two limits.</summary>
        public static long GradeCommitsCommand(long limit, long seed)
        {
            if ((49 + limit) > (seed - seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= (3.1 / 6.0))
                {
                    return 1;
                }
                else
                {
                    if ((3.7 / 6.0) == (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3 - limit) > (limit / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + 8) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer notes measurements.</summary>
        public static double SmoothBufferNotes(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= rate)
            {
                ratio = (ratio - 4.4) - span;
            }
            return ratio + ratio;
        }
    }
}
