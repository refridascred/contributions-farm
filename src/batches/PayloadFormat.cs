using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token report samples are out of range.</summary>
        public static long CountTokenReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((-3) >> 1) == (matches / 5)) && (((double)reading == (12.0 + 19.0)) || ((reading % 16) < reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Audit farm report readings against a rule.</summary>
        public static long CountFarmReportMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((1 - limit) <= (seen % 2)) && ((6 + limit) >= 0)) || ((6.66 * 5.4) >= 10.0))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster layout counter forward.</summary>
        public static long DeriveClusterLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor + step) % 97) + (long)i2;
                    anchor = (anchor - step) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
