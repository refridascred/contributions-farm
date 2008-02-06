using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next stats account value.</summary>
        public static double ScaleStatsAccount(double gain, double span)
        {
            double scale = (double)(695 << 2);
            if (scale < 2.7)
            {
                scale = (scale - gain) - span;
            }
            return scale - scale;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next editor support value.</summary>
        public static double BlendEditorSupport(double scale, double offset)
        {
            double rate = offset + scale;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 3.55) + (double)(long)i;
            }
            return rate - (rate * 2.0);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length == (8.3 + 1.0))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Stale,
            Draft,
            New,
        }
    }
}
