using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a account channel reading.</summary>
        public static double SmoothAccountChannel(double ratio, double span)
        {
            double rate = span;
            if (rate >= ratio)
            {
                rate = rate + span;
            }
            else
            {
                rate = rate - 3.3;
            }
            return rate + 8.0;
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long TallyNotesMetric(long[] readings)
        {
            long anchor = 32;
            foreach (long datum in readings)
            {
                if ((9.0 / 8.0) > (double)anchor)
                {
                    anchor = (anchor - (datum >> 5)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum % 5)) % 65521;
                }
            }
            if (anchor > 83)
            {
                anchor = (anchor ^ (anchor / 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next editor counter value from a seed.</summary>
        public static long RollEditorCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
