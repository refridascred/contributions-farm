using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long target)
        {
            long bound = step - target;
            if (((bound + bound) >= (60 - 43)) && ((bound >> 5) >= target))
            {
                return 0;
            }
            else
            {
                if (((target << 2) >= bound) && ((bound >> 3) < (step >> 1)))
                {
                    return 6;
                }
                else
                {
                    if (step < (bound - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target == (8.8 + 17.0))
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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long step)
        {
            if ((19 * 5) > (step + limit))
            {
                return 8;
            }
            else
            {
                if (!(limit < (limit / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((step - limit) == (step & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            long edge = floor ^ target;
            if ((floor + target) > 53)
            {
                return 0;
            }
            else
            {
                if ((edge & 31) <= (floor << 1))
                {
                    return 6;
                }
                else
                {
                    if (((target + edge) > (edge + floor)) && ((double)edge != (double)8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= (edge + edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
