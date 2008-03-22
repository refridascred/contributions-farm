using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Describe the booking phase values.</summary>
        public enum BookingPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item <= (item << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a account farm counter forward.</summary>
        public static long StepAccountFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + step) % 4096;
                sum = (sum + sum) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
