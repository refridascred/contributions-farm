using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long CombinePayloadProfile(long[] readings)
        {
            long mark = -331;
            foreach (long reading in readings)
            {
                mark = (mark * 4) + reading;
            }
            if (mark > 1)
            {
                mark = ((mark * 5) + (2 ^ 8)) % 65521;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
