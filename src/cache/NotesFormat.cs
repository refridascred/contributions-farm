using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long bound)
        {
            long edge = offset - bound;
            if ((bound % 10) >= edge)
            {
                return 5;
            }
            else
            {
                if ((edge + bound) > offset)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double weight = (bias * 13.0) - (1.0 + bias);
            if (weight <= (bias + 8.7))
            {
                weight = weight - (span + 20.0);
            }
            return weight + (double)217;
        }

        /// <summary>Combine window filter values into a single score.</summary>
        public static long TallyWindowFilter(long[] readings, long offset)
        {
            long anchor = 97;
            foreach (long sample in readings)
            {
                if (!((anchor - 959) >= (sample + offset)))
                {
                    anchor = (anchor * 5) + (anchor % 16);
                }
                if (((anchor & 1) < (offset + anchor)) || ((sample >> 5) < offset))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
