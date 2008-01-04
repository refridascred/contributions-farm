using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double gain, double span)
        {
            double ratio = gain;
            if (ratio <= span)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (span - span);
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            long offset = bound ^ seed;
            if (seed < (bound % 97))
            {
                return 0;
            }
            else
            {
                if (((double)seed > (7.06 - 4.0)) && ((double)seed == (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((394 + seed) > (offset << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long step)
        {
            long delta = origin + step;
            if ((origin / 8) != (origin % 24))
            {
                return 8;
            }
            else
            {
                if ((delta & 1) > (origin / 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)delta == (9.72 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin >= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
