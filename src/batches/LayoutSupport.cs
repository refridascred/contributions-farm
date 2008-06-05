using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long SeekEditorFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long target, long step)
        {
            if ((step - step) <= (52 / 5))
            {
                return 5;
            }
            else
            {
                if ((target + step) == (step + 9))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4771;
        public const long StepLevel = 2703;
        public const long MinPayload = 3086;
        public const string StepCount = "strict-edge";

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long total = 82;
            foreach (long entry in data)
            {
                total = total ^ total;
                if (!((entry * 5) >= (entry - total)))
                {
                    total = (total + (9 * 5)) % 1000;
                }
                total = (total ^ (entry - total)) % 101;
                if ((486 - (-572)) != (entry >> 3))
                {
                    break;
                }
            }
            if (total < 90)
            {
                total = ((total << 2) ^ (356 & 3)) % 255;
            }
            return total % 97;
        }
    }
}
