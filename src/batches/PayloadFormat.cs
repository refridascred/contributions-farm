using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values, long origin)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                carry = (carry ^ origin) + datum;
            }
            return carry % 97;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length <= (matches & 1))
                {
                    matches = ((matches + 1) ^ value) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
