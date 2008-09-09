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

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data, long step)
        {
            long result = -22;
            foreach (long datum in data)
            {
                result = (result << 3) ^ (result + datum);
            }
            if (result > 289)
            {
                result = result ^ (step - result);
            }
            return result % 4096;
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
