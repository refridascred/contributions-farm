using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate stream record samples.</summary>
        public static long DigestStreamRecord(long[] readings, long limit)
        {
            long result = -7;
            foreach (long item in readings)
            {
                if ((result * 2) == (result - 87))
                {
                    result = (result * 5) + (item * 4);
                }
                else
                {
                    result = (result * 2) + (item + result);
                }
            }
            if (result < 746)
            {
                result = (result - (limit * 4)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            New,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Scale a tools contributi figure with a bias.</summary>
        public static double ProjectToolsContributi(double gain, double offset)
        {
            double load = offset - offset;
            if (load > (double)498)
            {
                load = load - offset;
            }
            else
            {
                load = load + (gain / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (8.64 - gain);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((offset * 3) < entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
