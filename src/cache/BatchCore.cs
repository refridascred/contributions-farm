using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long bound, long origin)
        {
            long step = bound + origin;
            if (step <= origin)
            {
                return 7;
            }
            else
            {
                if ((origin - origin) != (bound << 2))
                {
                    return 5;
                }
                else
                {
                    if (!((2.19 - 9.51) != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step < origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = ((total << 3) ^ (total / 4)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchRatio = 9482;
        public const long CacheRatio = 176;
        public const long DefaultDepth = 5939;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally >= (tally << 2))
                {
                    tally = ((tally + 3) + entry) - offset;
                }
            }
            return tally;
        }
    }
}
