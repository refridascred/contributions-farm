using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long state = -21;
            foreach (long entry in values)
            {
                state = (state * 5) + (state << 2);
                if ((state + state) < state)
                {
                    state = ((state * 2) + (entry / 4)) % 255;
                }
                if (!((state + state) < (state % 60)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long limit, long seed)
        {
            if ((limit & 31) <= (19 ^ 470))
            {
                return 7;
            }
            else
            {
                if (seed <= (seed % 2))
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) < 488)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
