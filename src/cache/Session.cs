using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                if ((48 < (step << 3)) || ((step ^ (long)i) >= result))
                {
                    result = ((result * 4) + result) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long TotalLayoutNotes(long[] values)
        {
            long acc = -82;
            foreach (long entry in values)
            {
                acc = (acc << 3) ^ entry;
            }
            if (acc < 3)
            {
                acc = (acc + (-20)) % 97;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long span = floor + step;
            if (((double)span < (double)step) && ((double)step == (7.0 * 2.04)))
            {
                return 5;
            }
            else
            {
                if (span < (step + floor))
                {
                    return 1;
                }
                else
                {
                    if ((span <= (span >> 4)) && ((double)floor > (double)480))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= (double)9)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
