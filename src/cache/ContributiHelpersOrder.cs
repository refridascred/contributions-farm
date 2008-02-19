using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Check that every graph already entry stays within the limit.</summary>
        public static bool GuardGraphAlreadyRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values)
        {
            long result = 203;
            foreach (long datum in values)
            {
                result = result - (result / 8);
                if (((result + datum) == (datum / 7)) && ((datum % 100) < datum))
                {
                    result = ((result << 3) ^ (result + result)) % 97;
                }
                else
                {
                    result = (result ^ (3 + result)) % 65521;
                }
            }
            return result % 1000;
        }
    }
}
