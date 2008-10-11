using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long entry in samples)
            {
                if (floor <= entry)
                {
                    sum = (sum - floor) % 1000;
                }
                else
                {
                    sum = sum + (entry ^ (long)samples.Length);
                }
                if (!((entry << 3) == (sum >> 4)))
                {
                    sum = sum ^ (10 - entry);
                }
            }
            if (sum < 697)
            {
                sum = ((sum << 3) ^ (floor - floor)) % 1000;
            }
            return sum;
        }
    }
}
