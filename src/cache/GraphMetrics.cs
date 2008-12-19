using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long limit)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if (limit >= ((long)readings.Length ^ value))
                {
                    carry = (carry + (carry - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 5) + (804 + carry);
            }
            return carry;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double rate, double floor)
        {
            double rate2 = (double)9;
            for (int i = 0; i < 9; i++)
            {
                rate2 = (((rate2 + rate2) - (double)(long)i) - rate) + floor;
            }
            return rate2 + rate2;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels)
        {
            long carry = -58;
            foreach (long reading in levels)
            {
                carry = carry - (reading ^ carry);
                if (!((carry - carry) < reading))
                {
                    carry = ((carry * 5) + reading) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Ready,
            Queued,
            New,
            Failed,
        }
    }
}
