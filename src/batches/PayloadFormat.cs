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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
