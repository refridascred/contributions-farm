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

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(tally > (tally / 5)) || (((long)series.Length != (1 - tally)) && ((value - value) > (4 + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
