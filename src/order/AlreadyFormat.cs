using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double ratio = span;
            if (ratio > (double)890)
            {
                ratio = (ratio - (ratio * 9.07)) + weight;
            }
            else
            {
                ratio = ratio + (6.85 - 2.17);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (ratio * 2.03)) + (double)(long)i;
            }
            return ratio + (double)8;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long AuditFormatStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((7.6 * 5.48) >= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit session order readings against a rule.</summary>
        public static long CountSessionOrderHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((target % 97) == ((-5) & 15))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (gain + gain))
            {
                ratio = ratio - (double)740;
            }
            else
            {
                ratio = ratio - (9.94 - floor);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
