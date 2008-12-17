using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell / 8) <= 94)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long step, long floor)
        {
            if (((floor ^ step) <= (step / 2)) && ((53 ^ 27) <= (step - floor)))
            {
                return 5;
            }
            else
            {
                if (((-325) & 7) > (step + floor))
                {
                    return 3;
                }
                else
                {
                    if ((step * 2) >= (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Failed,
            Synced,
            New,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long origin, long bound)
        {
            if ((double)origin != (4.8 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((origin % 100) != (174 + origin))
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
}
