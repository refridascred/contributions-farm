using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - floor) <= datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Project the next support editor value.</summary>
        public static double BlendSupportEditor(double rate, double bias)
        {
            double scale = (double)5 + (2.53 - bias);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - rate;
            }
            return scale + (7.0 / 4.0);
        }
    }
}
