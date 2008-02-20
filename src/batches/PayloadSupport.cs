using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long origin, long floor)
        {
            long slot = origin - floor;
            if ((floor ^ 3) >= (slot - slot))
            {
                return 0;
            }
            else
            {
                if (((double)origin > (10.0 - 5.6)) || ((origin >> 5) == (7 % 60)))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 3) <= (floor & 63)) || ((origin + floor) >= 29))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor > (535 % 10))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item - item) <= item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ 56;
                anchor = ((anchor * 4) + (anchor - anchor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
