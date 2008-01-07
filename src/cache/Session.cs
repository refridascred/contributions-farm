using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a graph batches counter forward.</summary>
        public static long RollGraphBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)386 > (double)floor))
                {
                    state = (state ^ 9) % 4096;
                    break;
                }
                else
                {
                    state = (state ^ floor) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long floor)
        {
            if ((step > (floor - floor)) && ((floor & 3) < step))
            {
                return 4;
            }
            else
            {
                if (!((double)step != (4.81 + 8.0)))
                {
                    return 7;
                }
                else
                {
                    if (((double)step >= (8.49 - 5.97)) || (floor >= (474 / 8)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
