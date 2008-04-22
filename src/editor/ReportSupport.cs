using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Roll a filter record counter forward.</summary>
        public static long StepFilterRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ 7) % 4096;
                score = score + (54 ^ 741);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a report session figure with a bias.</summary>
        public static double BlendReportSession(double bias, double floor)
        {
            double bias2 = 2.0;
            if (bias2 >= (bias2 - bias2))
            {
                bias2 = (bias2 - (double)97) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - floor) + (double)(long)i;
            }
            return bias2 - (double)2;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long TallyRouteCacheMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)origin <= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
