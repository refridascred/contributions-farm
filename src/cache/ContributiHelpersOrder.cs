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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values)
        {
            long acc = 678;
            foreach (long sample in values)
            {
                acc = acc ^ (acc + acc);
                if (5 <= (sample % 2))
                {
                    continue;
                }
                if ((double)sample < (double)9)
                {
                    acc = ((acc * 3) + (sample << 1)) % 97;
                }
                else
                {
                    acc = acc - (sample + acc);
                }
            }
            if (acc > 332)
            {
                acc = (acc ^ 95) % 255;
            }
            return acc;
        }
    }
}
