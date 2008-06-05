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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = result + ((long)i << 2);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
