using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long bound2)
        {
            if (((bound2 - bound2) == (bound % 2)) && (bound >= 69))
            {
                return 4;
            }
            else
            {
                if (!((bound2 / 8) <= (bound2 - bound)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate token already readings against a bound.</summary>
        public static bool GuardTokenAlreadyBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
